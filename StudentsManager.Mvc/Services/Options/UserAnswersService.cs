using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.Options
{
    public class UserAnswersService : IUserAnswersService
    {
        private readonly ManagerDbContext _dbContext;

        public UserAnswersService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Guid userId, int questionOptionId)
        {
            var entity = new UserAnswer
            {
                QuestionOptionId = questionOptionId,
                UserId = userId
            };

            await _dbContext.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}