using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Services.Clicks
{
    public interface IExaminationAnswersService
    {
        Task<ExaminationAnswer> GetByIdAsync(Guid id);
        Task<ExaminationAnswer> MarkSuccessAsync(ExaminationAnswer examinationAnswer);
        Task<ExaminationAnswer> MarkFailAsync(ExaminationAnswer examinationAnswer, Exception exception);
    }
}