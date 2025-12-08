using StudentsManager.Mvc.Domain.Views.Homeworks;

namespace StudentsManager.Mvc.Services.Homeworks
{
    public interface IHomeworksService
    {
        Task<IReadOnlyCollection<HomeworkView>> GetByUserAsync(Guid userId);
        Task UploadAsync(Guid userId, Guid topicId, string topicTag, IFormFile? file, string repositoryLink);
    }
}