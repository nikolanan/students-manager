using StudentsManager.Mvc.Domain.Views;

namespace StudentsManager.Mvc.Services.Topics
{
    public interface ITopicsService
    {
        Task<IEnumerable<UserTopicResultView>> GetUserTopicResultsAsync(Guid userId);

        Task<bool> HasUserTopicResultAsync(Guid userId, Guid topicId);
    }
}