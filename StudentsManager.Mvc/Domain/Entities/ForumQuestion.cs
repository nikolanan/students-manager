namespace StudentsManager.Mvc.Domain.Entities
{
    public class ForumQuestion
    {
        public int Id { get; set; }

        public string Description { get; set; }

        // Reference
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public ICollection<ForumComment>? Comments { get; set; }
    }
}