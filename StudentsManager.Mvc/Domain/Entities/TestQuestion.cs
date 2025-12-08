namespace StudentsManager.Mvc.Domain.Entities
{
    public class TestQuestion
    {
        public Guid Id { get; set; }

        public string Description { get; set; }

        // Relations
        public Guid TopicId { get; set; }

        public Topic? Topic { get; set; }

        public ICollection<QuestionOption>? Options { get; set; }
    }
}