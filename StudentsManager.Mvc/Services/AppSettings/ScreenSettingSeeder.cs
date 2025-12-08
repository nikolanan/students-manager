using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Services.AppSettings
{
    public static class ScreenSettingSeeder
    {
        public static readonly ScreenSetting RegistrationScreenSetting = new()
        {
            Type = ScreenSettingConstants.RegistrationScreenType,
            Enabled = true
        };

        public static readonly List<ScreenSetting> ScreenSettings = new()
        {
            RegistrationScreenSetting
        };
    }
}