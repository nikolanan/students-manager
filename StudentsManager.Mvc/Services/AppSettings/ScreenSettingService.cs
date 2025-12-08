using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.AppSettings
{
    public class ScreenSettingService : IScreenSettingService
    {
        private readonly ManagerDbContext _dbContext;

        public ScreenSettingService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<ScreenSetting?> RegistrationScreenSettingAsync =>
            _dbContext
                .ScreenSettings
                .FirstOrDefaultAsync(setting => setting.Type == ScreenSettingConstants.RegistrationScreenType);

        public async Task<ScreenSetting?> UpdateRegistrationScreenSettingAsync(bool enabled)
        {
            var entity = await RegistrationScreenSettingAsync;
            if (entity == null)
            {
                return null;
            }
            entity.Enabled = enabled;
            _dbContext.ScreenSettings.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}