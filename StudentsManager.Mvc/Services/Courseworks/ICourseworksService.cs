using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Services.Courseworks
{
    public interface ICourseworksService
    {
        Task<UserCoursework> GetByUserIdAsync(Guid userId);

        Task<UserCoursework> SaveOrUpdateAsync(string link, Guid userId);
    }
}