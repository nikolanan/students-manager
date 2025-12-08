namespace StudentsManager.Mvc.Domain.Entities
{
    public class ForumComment
    {
        public int Id { get; set; }

        public string Description { get; set; }

        // Reference
        public int ForumQuestionId { get; set; }
        public ForumQuestion? ForumQuestion { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}