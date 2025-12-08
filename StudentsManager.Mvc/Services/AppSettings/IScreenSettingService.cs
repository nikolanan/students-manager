using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Services.AppSettings
{
    public interface IScreenSettingService
    {
        Task<ScreenSetting?> RegistrationScreenSettingAsync { get; }

        Task<ScreenSetting?> UpdateRegistrationScreenSettingAsync(bool enabled);
    }
}