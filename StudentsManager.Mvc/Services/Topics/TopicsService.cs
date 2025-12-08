using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Views;
using StudentsManager.Mvc.Mappings;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.Topics
{
    public class TopicsService : ITopicsService
    {
        private readonly ManagerDbContext _dbContext;

        public TopicsService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<UserTopicResultView>> GetUserTopicResultsAsync(Guid userId)
        {
            var userTopicIdResults = await _dbContext
                .UserTopicResults
                .Where(ut => ut.UserId == userId)
                .Select(ut => ut.TopicId)
                .ToListAsync();

            var topics = await _dbContext
                .Topics
                .OrderBy(topic => topic.SequenceNumber)
                .ToListAsync();

            return userTopicIdResults.Any()
                ? topics.Select(topic => topic.ToUserResult(userId,
                    userTopicIdResults.Any(id => id == topic.Id)))
                : topics.Select(topic => topic.ToUserResult(userId, false));
        }

        public Task<bool> HasUserTopicResultAsync(Guid userId, Guid topicId)
        {
            return _dbContext
                .UserTopicResults
                .AnyAsync(ut => ut.TopicId == topicId && ut.UserId == userId);
        }
    }
}