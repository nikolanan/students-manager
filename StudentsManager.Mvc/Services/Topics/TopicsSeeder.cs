using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Services.Courses;

namespace StudentsManager.Mvc.Services.Topics
{
    public static class TopicsSeeder
    {
        public static readonly Topic IntroTopic = new()
        {
            Id = Guid.Parse("b723c3c2-0f1e-46c3-83df-db08d3e4af2e"),
            Description = "Въведение в JS",
            Tag = "intro",
            SequenceNumber = 1,
            ExerciseFileUrl = "https://github.com/profjordanov/hybrid-app-development/blob/master/docs/intro.pdf",
            ResourcesUrl =
                "https://github.com/profjordanov/hybrid-app-development/tree/master/01.%20%D0%92%D1%8A%D0%B2%D0%B5%D0%B4%D0%B5%D0%BD%D0%B8%D0%B5%20%D0%B2%20JS",
            CanBeSeenAfter = DateTimeOffset.UtcNow,
            CourseId = CourseSeeder.HybridMobileAppCourse.Id
        };

        public static readonly Topic AdvanceTopic = new()
        {
            Id = Guid.Parse("03497bf4-9956-4d45-aacf-0363ec0a1142"),
            Description = "JS за напреднали",
            Tag = "advance",
            SequenceNumber = 2,
            ExerciseFileUrl = "https://github.com/profjordanov/hybrid-app-development/blob/master/docs/advanced.pdf",
            ResourcesUrl =
                "https://github.com/profjordanov/hybrid-app-development/raw/master/02.%20JS%20%D0%B7%D0%B0%20%D0%BD%D0%B0%D0%BF%D1%80%D0%B5%D0%B4%D0%BD%D0%B0%D0%BB%D0%B8/advanced.zip",
            CanBeSeenAfter = DateTimeOffset.UtcNow,
            CourseId = CourseSeeder.HybridMobileAppCourse.Id
        };

        public static readonly Topic AsyncProgrammingTopic = new()
        {
            Id = Guid.Parse("c316c9e2-bb08-436b-82e3-45e26baeb8bc"),
            Description = "Async JS",
            Tag = "async",
            SequenceNumber = 3,
            ExerciseFileUrl = "https://github.com/profjordanov/hybrid-app-development/blob/master/docs/async.pdf",
            ResourcesUrl =
                "https://github.com/profjordanov/hybrid-app-development/raw/master/03.%20Async%20JS/Library.zip",
            CourseId = CourseSeeder.HybridMobileAppCourse.Id
        };

        public static readonly Topic JqueryTopic = new()
        {
            Id = Guid.Parse("0aa79b3f-8b6e-414e-b365-8a2306ce519c"),
            Description = "jQuery Mobile",
            Tag = "jquery",
            SequenceNumber = 4,
            ExerciseFileUrl =
                "https://github.com/profjordanov/hybrid-app-development/blob/master/docs/cordova-jquery.pdf",
            ResourcesUrl = "https://github.com/profjordanov/hybrid-app-development/tree/master/04.%20Cordova%20jQuery"
        };

        public static readonly Topic CordovaIntroTopic = new()
        {
            Id = Guid.Parse("9579137b-84a6-4bd5-a866-2dcdbc77c5cf"),
            Description = "Apache Cordova",
            Tag = "cordova",
            SequenceNumber = 5,
            ExerciseFileUrl =
                "https://github.com/profjordanov/hybrid-app-development/blob/master/docs/cordova-plugins.pdf",
            ResourcesUrl =
                "https://github.com/profjordanov/hybrid-app-development/blob/master/05.%20Cordova%20Plugins/coords.json",
            CourseId = CourseSeeder.HybridMobileAppCourse.Id
        };

        public static readonly Topic OnsenTopic = new()
        {
            Id = Guid.Parse("0a6651a5-a4ce-4cc1-ac53-3f2cf1f40f8d"),
            Description = "Onsen UI",
            Tag = "onsen",
            SequenceNumber = 6,
            ExerciseFileUrl = "https://github.com/profjordanov/hybrid-app-development/blob/master/docs/onsen.pdf",
            ResourcesUrl = "#",
            CourseId = CourseSeeder.HybridMobileAppCourse.Id
        };

        public static readonly Topic ReactTopic = new()
        {
            Id = Guid.Parse("675b224d-e5e0-4923-be41-9c7ed2f28fcf"),
            Description = "React",
            Tag = "react",
            SequenceNumber = 7,
            ExerciseFileUrl = "https://github.com/profjordanov/hybrid-app-development/blob/master/docs/react.pdf",
            ResourcesUrl = "#",
            CourseId = CourseSeeder.HybridMobileAppCourse.Id
        };

        public static readonly List<Topic> Topics = new()
        {
            IntroTopic, AdvanceTopic, AsyncProgrammingTopic,
            JqueryTopic, CordovaIntroTopic,
            OnsenTopic, ReactTopic
        };
    }
}