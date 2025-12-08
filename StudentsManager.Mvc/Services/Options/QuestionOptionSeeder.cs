using StudentsManager.Mvc.Domain.Entities;
using static StudentsManager.Mvc.Services.Questions.TestQuestionSeeder;

namespace StudentsManager.Mvc.Services.Options
{
    public static class QuestionOptionSeeder
    {
        /// Intro question options
        public static readonly QuestionOption IntroQuestionOptionA = new()
        {
            Description = "<script>",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion.Id,
            TestQuestion = IntroQuestion
        };

        public static readonly QuestionOption IntroQuestionOptionB = new()
        {
            Description = "<javascript>",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion.Id,
            TestQuestion = IntroQuestion
        };

        public static readonly QuestionOption ActiveIntroQuestionOptionA = new()
        {
            Description = "V8",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = ActiveIntroQuestion.Id,
            TestQuestion = ActiveIntroQuestion,
            ImageAddress =
                "https://upload.wikimedia.org/wikipedia/commons/thumb/3/3f/V8_JavaScript_engine_logo_2.svg/1200px-V8_JavaScript_engine_logo_2.svg.png"
        };

        public static readonly QuestionOption ActiveIntroQuestionOptionB = new()
        {
            Description = "Javac",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = ActiveIntroQuestion.Id,
            TestQuestion = ActiveIntroQuestion,
            ImageAddress = "https://www.sussexplumbingsupplies.co.uk/wp-content/uploads/2020/01/Javac.jpg"
        };

        public static readonly QuestionOption IntroQuestion1A = new()
        {
            Description = "<script src=xxx.js>",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion1.Id,
            TestQuestion = IntroQuestion1
        };

        public static readonly QuestionOption IntroQuestion1B = new()
        {
            Description = "<script href=xxx.js>",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion1.Id,
            TestQuestion = IntroQuestion1
        };

        public static readonly QuestionOption IntroQuestion2A = new()
        {
            Description = "var colors = [\"red\", \"green\", \"blue\"]",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion2.Id,
            TestQuestion = IntroQuestion2
        };

        public static readonly QuestionOption IntroQuestion2B = new()
        {
            Description = "var colors = (1:\"red\", 2:\"green\", 3:\"blue\")",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion2.Id,
            TestQuestion = IntroQuestion2
        };

        public static readonly QuestionOption IntroQuestion3A = new()
        {
            Description = "NaN",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion3.Id,
            TestQuestion = IntroQuestion3
        };

        public static readonly QuestionOption IntroQuestion3B = new()
        {
            Description = "true",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion3.Id,
            TestQuestion = IntroQuestion3
        };

        public static readonly QuestionOption IntroQuestion4A = new()
        {
            Description = "Не",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion4.Id,
            TestQuestion = IntroQuestion4,
            ImageAddress = "https://miro.medium.com/max/620/1*zQbyAgtmT9Mje1DbdXnKPg.jpeg"
        };

        public static readonly QuestionOption IntroQuestion4B = new()
        {
            Description = "Да",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion4.Id,
            TestQuestion = IntroQuestion4,
            ImageAddress = "https://pbs.twimg.com/profile_images/823806405207531525/lEKvHWxY_400x400.jpg"
        };

        public static readonly QuestionOption IntroQuestion5A = new()
        {
            Description = "document.addCookie(oreo);",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion5.Id,
            TestQuestion = IntroQuestion5
        };

        public static readonly QuestionOption IntroQuestion5B = new()
        {
            Description = "document.cookie = \"key1 = value1;\"",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion5.Id,
            TestQuestion = IntroQuestion5
        };

        public static readonly QuestionOption IntroQuestion6A = new()
        {
            Description = "number",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion6.Id,
            TestQuestion = IntroQuestion6
        };

        public static readonly QuestionOption IntroQuestion6B = new()
        {
            Description = "string",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion6.Id,
            TestQuestion = IntroQuestion6
        };

        public static readonly QuestionOption IntroQuestion7A = new()
        {
            Description = "Вярно",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion7.Id,
            TestQuestion = IntroQuestion7,
            ImageAddress = "https://upload.wikimedia.org/wikipedia/commons/1/1c/True_Corporation_%28Thailand%29.svg"
        };

        public static readonly QuestionOption IntroQuestion7B = new()
        {
            Description = "Грешно",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion7.Id,
            TestQuestion = IntroQuestion7,
            ImageAddress = "https://image.shutterstock.com/image-vector/false-stampstampsignfalse-260nw-437357437.jpg"
        };

        public static readonly QuestionOption IntroQuestion8A = new()
        {
            Description = "var objclone = Object.assign({},obj);",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion8.Id,
            TestQuestion = IntroQuestion8
        };

        public static readonly QuestionOption IntroQuestion8B = new()
        {
            Description = "var objclone = Object.create(obj);",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = IntroQuestion8.Id,
            TestQuestion = IntroQuestion8
        };

        public static readonly QuestionOption IntroQuestion9A = new()
        {
            Description = "Вярно",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion9.Id,
            TestQuestion = IntroQuestion9,
            ImageAddress = "https://upload.wikimedia.org/wikipedia/commons/1/1c/True_Corporation_%28Thailand%29.svg"
        };

        public static readonly QuestionOption IntroQuestion9B = new()
        {
            Description = "Грешно",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion9.Id,
            TestQuestion = IntroQuestion9,
            ImageAddress = "https://image.shutterstock.com/image-vector/false-stampstampsignfalse-260nw-437357437.jpg"
        };

        public static readonly QuestionOption IntroQuestion10A = new()
        {
            Description = "Вярно",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion10.Id,
            TestQuestion = IntroQuestion10,
            ImageAddress = "https://upload.wikimedia.org/wikipedia/commons/1/1c/True_Corporation_%28Thailand%29.svg"
        };

        public static readonly QuestionOption IntroQuestion10B = new()
        {
            Description = "Грешно",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = IntroQuestion10.Id,
            TestQuestion = IntroQuestion10,
            ImageAddress = "https://image.shutterstock.com/image-vector/false-stampstampsignfalse-260nw-437357437.jpg"
        };

        public static readonly QuestionOption ActiveAdvanceQuestionOptionA = new()
        {
            Description = "NodeJS",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = ActiveAdvanceQuestion.Id,
            TestQuestion = ActiveAdvanceQuestion,
            ImageAddress = "https://d2eip9sf3oo6c2.cloudfront.net/tags/images/000/000/256/full/nodejslogo.png"
        };

        public static readonly QuestionOption ActiveAdvanceQuestionOptionB = new()
        {
            Description = "JVM",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = ActiveAdvanceQuestion.Id,
            TestQuestion = ActiveAdvanceQuestion,
            ImageAddress = "https://thebeginnerspoint.com/wp-content/uploads/2017/08/maxresdefault.jpg"
        };

        public static readonly QuestionOption AdvanceQuestionOptionA = new()
        {
            Description = "Итеративните свойства на обекта (The object's iterable properties)",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion.Id,
            TestQuestion = AdvanceQuestion
        };

        public static readonly QuestionOption AdvanceQuestionOptionB = new()
        {
            Description = "Частните Свойствата на обекта (object's private properties)",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion.Id,
            TestQuestion = AdvanceQuestion
        };

        public static readonly QuestionOption AdvanceQuestionOption1A = new()
        {
            Description = "Object.clear(array);",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion1.Id,
            TestQuestion = AdvanceQuestion1
        };

        public static readonly QuestionOption AdvanceQuestionOption1B = new()
        {
            Description = "arrayList.length = 0;",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion1.Id,
            TestQuestion = AdvanceQuestion1
        };

        public static readonly QuestionOption AdvanceQuestionOption2A = new()
        {
            Description = "Ползват се само при компонентно тестване от избраната работна рамка.",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion2.Id,
            TestQuestion = AdvanceQuestion2
        };

        public static readonly QuestionOption AdvanceQuestionOption2B = new()
        {
            Description = "Помагат да напишем модулен код, разделен в няколко файла.",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion2.Id,
            TestQuestion = AdvanceQuestion2
        };

        public static readonly QuestionOption AdvanceQuestionOption3A = new()
        {
            Description = "73",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion3.Id,
            TestQuestion = AdvanceQuestion3
        };

        public static readonly QuestionOption AdvanceQuestionOption3B = new()
        {
            Description = "10",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion3.Id,
            TestQuestion = AdvanceQuestion3
        };

        public static readonly QuestionOption AdvanceQuestionOption4A = new()
        {
            Description = "parseInt(\"4F\", 16);",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion4.Id,
            TestQuestion = AdvanceQuestion4
        };

        public static readonly QuestionOption AdvanceQuestionOption4B = new()
        {
            Description = "parseString(\"4F\", 16);",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion4.Id,
            TestQuestion = AdvanceQuestion4
        };

        public static readonly QuestionOption AdvanceQuestionOption5A = new()
        {
            Description = "Not a Numerable",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion5.Id,
            TestQuestion = AdvanceQuestion5
        };

        public static readonly QuestionOption AdvanceQuestionOption5B = new()
        {
            Description = "Not a Number",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion5.Id,
            TestQuestion = AdvanceQuestion5
        };

        public static readonly QuestionOption AdvanceQuestionOption6A = new()
        {
            Description = "window може да се счита за свойство на document",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion6.Id,
            TestQuestion = AdvanceQuestion6
        };

        public static readonly QuestionOption AdvanceQuestionOption6B = new()
        {
            Description = "document може да се счита за свойство на window",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion6.Id,
            TestQuestion = AdvanceQuestion6
        };

        public static readonly QuestionOption AdvanceQuestionOption7A = new()
        {
            Description = "Vue",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = AdvanceQuestion7.Id,
            TestQuestion = AdvanceQuestion7,
            ImageAddress =
                "https://upload.wikimedia.org/wikipedia/commons/thumb/9/95/Vue.js_Logo_2.svg/1200px-Vue.js_Logo_2.svg.png"
        };

        public static readonly QuestionOption AdvanceQuestionOption7B = new()
        {
            Description = "Spring",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = AdvanceQuestion7.Id,
            TestQuestion = AdvanceQuestion7,
            ImageAddress = "https://miro.medium.com/max/624/1*dwa1SCG85BAzQttURVUvrA.png"
        };

        public static readonly QuestionOption AdvanceQuestionOption8A = new()
        {
            Description = "Недефинираните променливи са тези, които не съществуват в програма и не са декларирани.",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion8.Id,
            TestQuestion = AdvanceQuestion8
        };

        public static readonly QuestionOption AdvanceQuestionOption8B = new()
        {
            Description = "Недекларираните променливи са тези, които не съществуват в програма и не са декларирани.",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion8.Id,
            TestQuestion = AdvanceQuestion8
        };

        public static readonly QuestionOption AdvanceQuestionOption9A = new()
        {
            Description = "Number",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion9.Id,
            TestQuestion = AdvanceQuestion9
        };

        public static readonly QuestionOption AdvanceQuestionOption9B = new()
        {
            Description = "Reference Error",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AdvanceQuestion9.Id,
            TestQuestion = AdvanceQuestion9
        };

        public static readonly List<QuestionOption> QuestionOptions = new()
        {
            IntroQuestionOptionA, IntroQuestionOptionB,
            AdvanceQuestionOptionA, AdvanceQuestionOptionB,
            ActiveIntroQuestionOptionA, ActiveIntroQuestionOptionB,
            ActiveAdvanceQuestionOptionA, ActiveAdvanceQuestionOptionB,
            IntroQuestion1A,
            IntroQuestion1B,
            IntroQuestion2A,
            IntroQuestion2B,
            IntroQuestion3A,
            IntroQuestion3B,
            IntroQuestion4A,
            IntroQuestion4B,
            IntroQuestion5A,
            IntroQuestion5B,
            IntroQuestion6A,
            IntroQuestion6B,
            IntroQuestion7A,
            IntroQuestion7B,
            IntroQuestion8A,
            IntroQuestion8B,
            IntroQuestion9A,
            IntroQuestion9B,
            IntroQuestion10A,
            IntroQuestion10B,

            AdvanceQuestionOption1A,
            AdvanceQuestionOption1B,
            AdvanceQuestionOption2A,
            AdvanceQuestionOption2B,
            AdvanceQuestionOption3A,
            AdvanceQuestionOption3B,
            AdvanceQuestionOption4A,
            AdvanceQuestionOption4B,
            AdvanceQuestionOption5A,
            AdvanceQuestionOption5B,
            AdvanceQuestionOption6A,
            AdvanceQuestionOption6B,
            AdvanceQuestionOption7A,
            AdvanceQuestionOption7B,
            AdvanceQuestionOption8A,
            AdvanceQuestionOption8B,
            AdvanceQuestionOption9A,
            AdvanceQuestionOption9B
        };
    }
}