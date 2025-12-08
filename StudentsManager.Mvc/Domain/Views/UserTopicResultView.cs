namespace StudentsManager.Mvc.Domain.Views
{
    public class UserTopicResultView
    {
        public Guid UserId { get; set; }

        public Guid TopicId { get; set; }

        public string TopicDescription { get; set; }

        public bool Passed { get; set; }
    }
}