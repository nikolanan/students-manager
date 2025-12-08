using StudentsManager.Mvc.Domain.Views.Home;

namespace StudentsManager.Mvc.Services.CourseExaminations
{
    public interface IExaminationSettingsService
    {
        Task<CourseExaminationSettingsView> GetViewAsync();
        Task<bool> CanAccessTheFirstAsync();
        Task<bool> CanAccessTheSecondAsync();
        Task MakeFirstAvailableAsync();
        Task MakeSecondAvailableAsync();
        Task MakeFirstUnavailableAsync();
        Task MakeSecondUnavailableAsync();
    }
}