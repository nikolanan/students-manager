namespace StudentsManager.Mvc.Domain.Entities
{
    public class UserAnswer
    {
        public int Id { get; set; }

        // Reference
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public int QuestionOptionId { get; set; }
        public QuestionOption? QuestionOption { get; set; }
    }
}