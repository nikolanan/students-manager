using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.Courseworks
{
    public class CourseworksService : ICourseworksService
    {
        private readonly ManagerDbContext _dbContext;

        public CourseworksService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<UserCoursework> GetByUserIdAsync(Guid userId)
        {
            return _dbContext
                .UserCourseworks
                .SingleOrDefaultAsync(coursework => coursework.UserId == userId);
        }

        public async Task<UserCoursework> SaveOrUpdateAsync(string link, Guid userId)
        {
            var entity = await GetByUserIdAsync(userId);
            if (entity == null)
            {
                var coursework = new UserCoursework
                {
                    Link = link,
                    UserId = userId
                };
                return await SaveAsync(coursework);
            }

            entity.Link = link;
            return await UpdateAsync(entity);
        }

        public async Task<UserCoursework> SaveAsync(UserCoursework entity)
        {
            await _dbContext.UserCourseworks.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<UserCoursework> UpdateAsync(UserCoursework entity)
        {
            _dbContext.UserCourseworks.Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}