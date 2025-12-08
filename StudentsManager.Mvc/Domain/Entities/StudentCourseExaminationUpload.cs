using File = StudentsManager.Mvc.Domain.Entities._Base.File;

namespace StudentsManager.Mvc.Domain.Entities
{
    public class StudentCourseExaminationUpload : File
    {
        public int Id { get; set; }

        public Guid StudentCourseExaminationId { get; set; }

        public StudentCourseExamination? StudentCourseExamination { get; set; }
    }
}