namespace StudentsManager.Mvc.Domain.Inputs.Students
{
    public class StudentExaminationScore
    {
        public Guid UserId { get; set; }

        public string Type { get; set; }

        public int Score { get; set; }
    }
}