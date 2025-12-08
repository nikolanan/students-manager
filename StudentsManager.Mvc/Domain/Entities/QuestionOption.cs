namespace StudentsManager.Mvc.Domain.Entities
{
    public class QuestionOption
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public bool IsTextOnly { get; set; }

        public bool IsCorrect { get; set; }

        public string? ImageAddress { get; set; }

        // Relations
        public Guid TestQuestionId { get; set; }

        public TestQuestion? TestQuestion { get; set; }

        public ICollection<UserAnswer>? UserAnswers { get; set; }
    }
}