using StudentsManager.Mvc.Domain.Entities;
using static StudentsManager.Mvc.Services.Topics.TopicsSeeder;

namespace StudentsManager.Mvc.Services.Questions
{
    public static class TestQuestionSeeder
    {
        // Intro
        public static readonly TestQuestion IntroQuestion = new()
        {
            Id = Guid.Parse("10d43977-e6ec-4413-ad86-4b1a9c20179a"),
            Description = "В кой HTML елемент поставяме JavaScript?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion ActiveIntroQuestion = new()
        {
            Id = Guid.Parse("373afe80-958b-4517-9979-495e9d30409e"),
            Description = "Кое от изброените е двигател за JavaScript?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion1 = new()
        {
            Id = Guid.Parse("ca81b886-efff-4d7d-8d97-0fae24dcda8f"),
            Description = "Какъв е правилният синтаксис за препратка към външен скрипт, наречен xxx.js?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion2 = new()
        {
            Id = Guid.Parse("cbfbda9b-6df7-4a18-a4a7-c26c7e40ee7e"),
            Description = "Какъв е правилният начин за инстациране на масив?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion3 = new()
        {
            Id = Guid.Parse("60522c02-3bae-4327-93f4-f3c49059642e"),
            Description = "Какво ще върне следният код: Boolean (10> 9)?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion4 = new()
        {
            Id = Guid.Parse("d33b9fb9-e831-44a6-81a8-78b7593cdcb0"),
            Description = "JS различава ли главни от малки букви?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion5 = new()
        {
            Id = Guid.Parse("d33b9fb9-e831-44a6-81a8-78b7593cdcb5"),
            Description = "Как да съсдадем бисквитка с помощта на JavaScript?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion6 = new()
        {
            Id = Guid.Parse("d99b9fb9-e831-44a6-81a8-78b7593cdcb5"),
            Description = "Какво би върнал: console.log(typeof typeof 1);",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion7 = new()
        {
            Id = Guid.Parse("d99b9fb9-e831-44a6-89a8-78b7593cdcb5"),
            Description = "Каква е стойността на: typeof undefined == typeof NULL?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion8 = new()
        {
            Id = Guid.Parse("53db64e0-f298-4594-91a5-1686fbd2d2b5"),
            Description = "Как се клонира обектa var obj = {a: 1 ,b: 2} ?",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion9 = new()
        {
            Id = Guid.Parse("53db64e0-f298-4594-91a5-9756fbd2d2b5"),
            Description = "Каква е стойността на: console.log(false == '0')",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        public static readonly TestQuestion IntroQuestion10 = new()
        {
            Id = Guid.Parse("90db64e0-f298-4594-91a5-9756fbd2d2b5"),
            Description = "Каква е стойността на: console.log(false === '0')",
            TopicId = IntroTopic.Id,
            Topic = IntroTopic
        };

        // Advance Topic
        public static readonly TestQuestion AdvanceQuestion = new()
        {
            Id = Guid.Parse("2172781a-ac1a-45de-88c2-6d444ee27d31"),
            Description = "Откъде идват стойностите в for...of ?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion ActiveAdvanceQuestion = new()
        {
            Id = Guid.Parse("2172781a-ac1a-45de-88c2-6d444ee27d36"),
            Description = "Кое от посочените е среда за изпълнение на JavaScript приложения?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion1 = new()
        {
            Id = Guid.Parse("6b4fb8aa-f53c-4b7a-b8ad-a0dd3d85b2a2"),
            Description = "Как да се зачиства масив в JS?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion2 = new()
        {
            Id = Guid.Parse("751e1014-2c79-45ff-8625-a2739b664810"),
            Description = "Какво представляват Exports & Imports?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion3 = new()
        {
            Id = Guid.Parse("ac3e7d59-78f3-447e-bc6c-e50adc1ac5c5"),
            Description = "Какъв би бил резултатът от 2 + 5 + '3' ?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion4 = new()
        {
            Id = Guid.Parse("00a61f00-70fa-4bda-b837-45fc30ecba5e"),
            Description = "Как може да се конвертира низ, на която и да е основа в цяло число?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion5 = new()
        {
            Id = Guid.Parse("e7a6ba36-fc73-48aa-adc8-49b314a1cfbb"),
            Description = "Какво означава NaN?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion6 = new()
        {
            Id = Guid.Parse("ca43fd78-74ae-4d26-99de-65d02fee180b"),
            Description = "Каква е разликата между window & document?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion7 = new()
        {
            Id = Guid.Parse("9a4c88a8-ebf9-466f-9588-488ac04e5de1"),
            Description = "Кое от следните е JS работна рамка?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion8 = new()
        {
            Id = Guid.Parse("e9486d45-b2ad-46bc-8fcd-b71e72edcd5d"),
            Description = "Каква е разликата между undeclared & undefined?",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly TestQuestion AdvanceQuestion9 = new()
        {
            Id = Guid.Parse("9f11a2d2-3436-4d81-8d58-472cc8d09fd3"),
            Description = "Какъв е изхода от следния код: var Foo = Function Bar(){return 7;}; typeof Bar();",
            TopicId = AdvanceTopic.Id,
            Topic = AdvanceTopic
        };

        public static readonly List<TestQuestion> TestQuestions = new()
        {
            ActiveIntroQuestion, IntroQuestion,
            AdvanceQuestion, ActiveAdvanceQuestion,
            IntroQuestion1,
            IntroQuestion2,
            IntroQuestion3,
            IntroQuestion4,
            IntroQuestion5,
            IntroQuestion6,
            IntroQuestion7,
            IntroQuestion8,
            IntroQuestion9,
            IntroQuestion10,

            AdvanceQuestion1,
            AdvanceQuestion2,
            AdvanceQuestion3,
            AdvanceQuestion4,
            AdvanceQuestion5,
            AdvanceQuestion6,
            AdvanceQuestion7,
            AdvanceQuestion8,
            AdvanceQuestion9
        };
    }
}