namespace StudentsManager.Mvc.Domain.Entities
{
    public class StudentCourseExamination
    {
        public Guid Id { get; set; }

        public int Score { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }

        public int CourseExaminationId { get; set; }
        public CourseExamination? CourseExamination { get; set; }

        public ICollection<StudentCourseExaminationUpload>? Uploads { get; set; }
    }
}