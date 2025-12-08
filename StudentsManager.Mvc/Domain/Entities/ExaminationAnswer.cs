using StudentsManager.Mvc.Domain.Entities._Base;

namespace StudentsManager.Mvc.Domain.Entities
{
    public class ExaminationAnswer : IAuditInfo
    {
        public Guid Id { get; set; }

        public string? Result { get; set; }
        public string? Form { get; set; }
        public string? ContentType { get; set; }

        public bool WasSuccessfullyProcessed { get; set; }
        public string? ErrorMessage { get; set; }

        // Reference
        public Guid UserId { get; set; }
        public User? User { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}