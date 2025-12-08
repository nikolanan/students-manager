namespace StudentsManager.Mvc.Domain.Views.Homeworks
{
    public class HomeworkView
    {
        public Guid TopicId { get; set; }
        public string? TopicDescription { get; set; }
        public string? VideoLinkFromPreviousYear { get; set; }
        public string? TopicTag { get; set; }
        public string? ExerciseFileUrl { get; set; }
        public string? ResourcesUrl { get; set; }
        public bool HasHanded { get; set; }
        public string? HomeWorkPath { get; set; }
    }
}