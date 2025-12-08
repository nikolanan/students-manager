using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.Topics
{
    public class UserTopicResultsService : IUserTopicResultsService
    {
        private readonly ManagerDbContext _dbContext;

        public UserTopicResultsService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<UserTopicResult> ProcessAsync(Guid topicId, Guid userId)
        {
            var userCorrectAnswersCount = await _dbContext
                .UserAnswers
                .Include(answer => answer.QuestionOption)
                .ThenInclude(option => option.TestQuestion)
                .Where(answer => answer.QuestionOption.IsCorrect &&
                                 answer.UserId == userId &&
                                 answer.QuestionOption.TestQuestion.TopicId == topicId)
                .CountAsync();

            var entity = new UserTopicResult
            {
                TopicId = topicId,
                UserId = userId,
                Score = CalculateScoreByAnswersCount(userCorrectAnswersCount)
            };

            await _dbContext.UserTopicResults.AddAsync(entity);
            await _dbContext.SaveChangesAsync();

            return entity;
        }

        public Task<UserTopicResult?> GetSingleAsync(Guid topicId, Guid userId)
        {
            return _dbContext
                .UserTopicResults
                .Include(result => result.Topic)
                .SingleOrDefaultAsync(result =>
                    result.TopicId == topicId && result.UserId == userId);
        }

        private static int CalculateScoreByAnswersCount(int userCorrectAnswersCount)
        {
            if (userCorrectAnswersCount > 4) return 10;
            return userCorrectAnswersCount > 2 ? 5 : 0;
        }
    }
}