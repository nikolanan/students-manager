using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Services.Topics
{
    public interface IUserTopicResultsService
    {
        Task<UserTopicResult> ProcessAsync(Guid topicId, Guid userId);

        Task<UserTopicResult?> GetSingleAsync(Guid topicId, Guid userId);
    }
}