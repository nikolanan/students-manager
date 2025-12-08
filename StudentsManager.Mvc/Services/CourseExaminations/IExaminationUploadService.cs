using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Services.CourseExaminations
{
    public interface IExaminationUploadService
    {
        Task<List<StudentCourseExaminationUpload>> GetAsync(Guid studentExaminationId);

        Task<StudentCourseExaminationUpload> AttachFileAsync(
            Guid studentExaminationId,
            string examinationType,
            IFormFile file,
            Guid userId);
    }
}