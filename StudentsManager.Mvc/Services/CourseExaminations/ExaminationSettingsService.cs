using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Views.Home;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.CourseExaminations
{
    public class ExaminationSettingsService : IExaminationSettingsService
    {
        private readonly ManagerDbContext _dbContext;

        public ExaminationSettingsService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<CourseExaminationSettingsView> GetViewAsync()
        {
            return new CourseExaminationSettingsView(await CanAccessTheFirstAsync(), await CanAccessTheSecondAsync());
        }

        public async Task<bool> CanAccessTheFirstAsync()
        {
            var entity = await FirstByTypeAsync(CourseExaminationConstants.FirstType);
            return entity is { Enabled: true };
        }

        public async Task<bool> CanAccessTheSecondAsync()
        {
            var entity = await FirstByTypeAsync(CourseExaminationConstants.SecondType);
            return entity is { Enabled: true };
        }

        public async Task MakeFirstAvailableAsync()
        {
            var entity = await FirstByTypeAsync(CourseExaminationConstants.FirstType);
            Debug.Assert(entity != null, nameof(entity) + " != null");
            entity.Enabled = true;
            await UpdateAsync(entity);
        }

        public async Task MakeSecondAvailableAsync()
        {
            var entity = await FirstByTypeAsync(CourseExaminationConstants.SecondType);
            Debug.Assert(entity != null, nameof(entity) + " != null");
            entity.Enabled = true;
            await UpdateAsync(entity);
        }

        public async Task MakeFirstUnavailableAsync()
        {
            var entity = await FirstByTypeAsync(CourseExaminationConstants.FirstType);
            Debug.Assert(entity != null, nameof(entity) + " != null");
            entity.Enabled = false;
            await UpdateAsync(entity);
        }

        public async Task MakeSecondUnavailableAsync()
        {
            var entity = await FirstByTypeAsync(CourseExaminationConstants.SecondType);
            if (entity == null) throw new ArgumentNullException(nameof(entity));
            entity.Enabled = false;
            await UpdateAsync(entity);
        }

        private Task<CourseExaminationSetting?> FirstByTypeAsync(string type)
        {
            return _dbContext
                .CourseExaminationSettings
                .FirstOrDefaultAsync(setting => setting.Type == type);
        }

        private async Task UpdateAsync(CourseExaminationSetting entity)
        {
            _dbContext.CourseExaminationSettings.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}