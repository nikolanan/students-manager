using System.Net.Mail;
using System.Text;
using Newtonsoft.Json;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Views.Cognitive;
using UserAnswer = StudentsManager.Mvc.Domain.Inputs.Click.UserAnswer;

namespace StudentsManager.Mvc.Services.Cognitive
{
    public class TextAnalyticService : ITextAnalyticService
    {
        public UserAnswerReportView ProcessReport(ExaminationAnswer entity)
        {
            var userAnswers = DeserializeUserAnswers(entity.Result);

            var reportResult =
                ProcessUserAnswers(userAnswers, entity.ContentType, CreateAndBeginReport(ParseName(entity)));

            return new UserAnswerReportView
            {
                Report = reportResult,
                UserMail = GetUserMail(entity)
            };
        }

        public string ProcessUserAnswers(IEnumerable<UserAnswer> userAnswers, string contentType,
            StringBuilder responseBuilder)
        {
            foreach (var userAnswer in userAnswers)
            {
                if (userAnswer?.Answer == null) continue;

                if (userAnswer.Answer.GetType() != typeof(string)) continue;

                switch ((string)userAnswer.Answer)
                {
                    case "No":
                        responseBuilder.AppendLine($"Question: {userAnswer.Question}. Answer: No. - WRONG.\n");
                        continue;
                    case "Yes":
                        responseBuilder.AppendLine($"Question: {userAnswer.Question}. Answer: Yes. - CORRECT.\n");
                        continue;
                }

                HashSet<string> keyPhrasesList;

                var haveKeyPhrases = contentType == "beginner"
                    ? BasicKeyPhrases.QuestionMappings.TryGetValue(userAnswer.Question, out keyPhrasesList)
                    : KeyPhrases.QuestionMappings.TryGetValue(userAnswer.Question, out keyPhrasesList);

                if (!haveKeyPhrases) continue;

                if (keyPhrasesList.Count == 1)
                {
                    if (keyPhrasesList.First() == (string)userAnswer.Answer)
                        responseBuilder.AppendLine(
                            $"Question: {userAnswer.Question}. Answer: {userAnswer.Answer} - CORRECT.\n");

                    responseBuilder.AppendLine(
                        $"Question: {userAnswer.Question}. Answer: {userAnswer.Answer} - WRONG. Correct - {keyPhrasesList.First()}\n");
                }

                var count = new Random().Next(20, 90);
                responseBuilder.AppendLine(
                    $"Question: {userAnswer.Question}. Answer: {userAnswer.Answer}. Correct on {count}%.");
            }

            return responseBuilder.ToString();
        }

        private static StringBuilder CreateAndBeginReport(string userFullName)
        {
            var responseBuilder = new StringBuilder();
            responseBuilder.AppendLine(
                $"Hello there {userFullName}, thanks for taking the examination in the students manager.\n" +
                "A machine algorithm processed your answers. You can find the report below: \n");

            return responseBuilder;
        }

        private static IEnumerable<UserAnswer> DeserializeUserAnswers(string result)
        {
            try
            {
                return JsonConvert.DeserializeObject<UserAnswer[]>(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private static string GetUserMail(ExaminationAnswer answer)
        {
            try
            {
                var result = ParseEmailFromFrom(answer.Form);
                var decodeResult = Uri.UnescapeDataString(result);
                var _ = new MailAddress(decodeResult);
                return decodeResult;
            }
            catch (Exception)
            {
                return answer.User.Email;
            }
        }

        // name=DAKA&email=d_yugioh%40abv.bg&hr-checkbox=1
        private static string ParseEmailFromFrom(string form)
        {
            var tokens = form.Split('&', StringSplitOptions.RemoveEmptyEntries);
            var emailTokens = tokens[1].Split('=', StringSplitOptions.RemoveEmptyEntries);
            return emailTokens[1];
        }

        private static string ParseName(ExaminationAnswer answer)
        {
            try
            {
                var tokens = answer.Form.Split('&', StringSplitOptions.RemoveEmptyEntries);
                var nameTokens = tokens[0].Split('=', StringSplitOptions.RemoveEmptyEntries);
                if (string.IsNullOrEmpty(nameTokens[1]) || string.IsNullOrWhiteSpace(nameTokens[1]))
                    return answer.User.FullName;

                return nameTokens[1];
            }
            catch (Exception)
            {
                return "UserName";
            }
        }
    }
}