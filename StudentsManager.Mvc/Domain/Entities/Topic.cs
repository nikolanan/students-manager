namespace StudentsManager.Mvc.Domain.Entities
{
    public class Topic
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Tag { get; set; }
        public int SequenceNumber { get; set; }
        public string ExerciseFileUrl { get; set; }
        public string ResourcesUrl { get; set; }
        public DateTimeOffset CanBeSeenAfter { get; set; }
        public string? VideoLinkFromPreviousYear { get; set; }

        public Guid? CourseId { get; set; }
        public Course? Course { get; set; }

        public ICollection<TestQuestion>? TestQuestions { get; set; }
        public ICollection<UserTopicResult>? UserTopics { get; set; }
        public ICollection<Homework>? Homeworks { get; set; }
    }
}