using StudentsManager.Mvc.Domain.Entities;
using static StudentsManager.Mvc.Services.Topics.TopicsSeeder;

namespace StudentsManager.Mvc.Services.Questions
{
    public static class AsyncProgrammingTopicSeeder
    {
        // Questions
        public static readonly TestQuestion AsyncQuestion1 = new()
        {
            Id = Guid.Parse("72ce36b0-c11e-4e76-abad-b8aebc79f6a4"),
            Description = "AJAX e ?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion2 = new()
        {
            Id = Guid.Parse("88ce36b0-c11e-4e76-abad-b8aebc79f6b9"),
            Description = "Какъв тип сървър поддържа AJAX?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion3 = new()
        {
            Id = Guid.Parse("95e355e9-ee02-40b1-ac6e-4cc8e6688b51"),
            Description = "Какво прави Ajax уникален?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion4 = new()
        {
            Id = Guid.Parse("c5253b87-6425-452e-9c39-b8e7ccccc75b"),
            Description =
                "Kоя от следните технологии предоставя възможност за динамично взаимодействие с оформлението на уеб страницата?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion5 = new()
        {
            Id = Guid.Parse("f105e87e-3afd-494d-a921-414bbd781120"),
            Description = "Обектът XMLHttpRequest може да бъде деактивиран чрез настройките на браузъра?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion6 = new()
        {
            Id = Guid.Parse("6e2627bf-a000-4c91-a665-5248d703be8f"),
            Description = "Кое свойство се използва за проверка дали AJAX заявката е изпълнена?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion7 = new()
        {
            Id = Guid.Parse("1b3231e2-c797-44a0-8b36-19171677c5c7"),
            Description = "Как можем да отменим XMLHttpRequest в AJAX?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion8 = new()
        {
            Id = Guid.Parse("e16563af-9395-472a-8845-9040e038a220"),
            Description = "Кои типове данни JSON НЕ поддържа?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion9 = new()
        {
            Id = Guid.Parse("81f79a36-b8f6-40b1-9d7d-2a696ea45d69"),
            Description =
                "Кой параметър jQuery AJAX .get (), .post () и .ajax () методите изискват да бъде предоставен?",
            TopicId = AsyncProgrammingTopic.Id
        };

        public static readonly TestQuestion AsyncQuestion10 = new()
        {
            Id = Guid.Parse("7552360e-d182-4041-820d-95917b9425f8"),
            Description = "Кое твърдение за XML е вярно?",
            TopicId = AsyncProgrammingTopic.Id
        };

        // Options
        public static readonly QuestionOption AsyncQuestionOption1A = new()
        {
            Description = "Програмен език",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion1.Id
        };

        public static readonly QuestionOption AsyncQuestionOption1B = new()
        {
            Description = "Технология",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion1.Id
        };

        public static readonly QuestionOption AsyncQuestionOption2A = new()
        {
            Description = "SMTP",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion2.Id
        };

        public static readonly QuestionOption AsyncQuestionOption2B = new()
        {
            Description = "HTTP",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion2.Id
        };

        public static readonly QuestionOption AsyncQuestionOption3A = new()
        {
            Description = "Прави заявки за данни асинхронно.",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion3.Id
        };

        public static readonly QuestionOption AsyncQuestionOption3B = new()
        {
            Description = "Работи като самостоятелен инструмент за уеб разработка.",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion3.Id
        };

        public static readonly QuestionOption AsyncQuestionOption4A = new()
        {
            Description = "Document Object Model",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion4.Id
        };

        public static readonly QuestionOption AsyncQuestionOption4B = new()
        {
            Description = "XML",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion4.Id
        };

        public static readonly QuestionOption AsyncQuestionOption5А = new()
        {
            Description = "Вярно",
            IsCorrect = false,
            IsTextOnly = false,
            TestQuestionId = AsyncQuestion5.Id,
            ImageAddress = "https://upload.wikimedia.org/wikipedia/commons/1/1c/True_Corporation_%28Thailand%29.svg"
        };

        public static readonly QuestionOption AsyncQuestionOption5B = new()
        {
            Description = "Грешно",
            IsCorrect = true,
            IsTextOnly = false,
            TestQuestionId = AsyncQuestion5.Id,
            ImageAddress = "https://image.shutterstock.com/image-vector/false-stampstampsignfalse-260nw-437357437.jpg"
        };

        public static readonly QuestionOption AsyncQuestionOption6A = new()
        {
            Description = "readyState",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion6.Id
        };

        public static readonly QuestionOption AsyncQuestionOption6B = new()
        {
            Description = "onreadyState",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion6.Id
        };

        public static readonly QuestionOption AsyncQuestionOption7A = new()
        {
            Description = "cancel()",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion7.Id
        };

        public static readonly QuestionOption AsyncQuestionOption7B = new()
        {
            Description = "abort()",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion7.Id
        };

        public static readonly QuestionOption AsyncQuestionOption8A = new()
        {
            Description = "ENUM",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion8.Id
        };

        public static readonly QuestionOption AsyncQuestionOption8B = new()
        {
            Description = "object",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion8.Id
        };

        public static readonly QuestionOption AsyncQuestionOption9A = new()
        {
            Description = "headers",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion9.Id
        };

        public static readonly QuestionOption AsyncQuestionOption9B = new()
        {
            Description = "url",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion9.Id
        };

        public static readonly QuestionOption AsyncQuestionOption10A = new()
        {
            Description = "Всеки XML документ трябва да започва с XML пролог.",
            IsCorrect = true,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion10.Id
        };

        public static readonly QuestionOption AsyncQuestionOption10B = new()
        {
            Description = "Всеки XML документ трябва да има маркер DOCTYPE.",
            IsCorrect = false,
            IsTextOnly = true,
            TestQuestionId = AsyncQuestion10.Id
        };

        public static readonly List<TestQuestion> AsyncQuestions = new()
        {
            AsyncQuestion1,
            AsyncQuestion2,
            AsyncQuestion3,
            AsyncQuestion4,
            AsyncQuestion5,
            AsyncQuestion6,
            AsyncQuestion7,
            AsyncQuestion8,
            AsyncQuestion9,
            AsyncQuestion10
        };

        public static readonly List<QuestionOption> AsyncQuestionOptions = new()
        {
            AsyncQuestionOption1A,
            AsyncQuestionOption1B,
            AsyncQuestionOption2A,
            AsyncQuestionOption2B,
            AsyncQuestionOption3A,
            AsyncQuestionOption3B,
            AsyncQuestionOption4A,
            AsyncQuestionOption4B,
            AsyncQuestionOption5А,
            AsyncQuestionOption5B,
            AsyncQuestionOption6A,
            AsyncQuestionOption6B,
            AsyncQuestionOption7A,
            AsyncQuestionOption7B,
            AsyncQuestionOption8A,
            AsyncQuestionOption8B,
            AsyncQuestionOption9A,
            AsyncQuestionOption9B,
            AsyncQuestionOption10A,
            AsyncQuestionOption10B
        };
    }
}