using StudentsManager.Mvc.Domain.Views;

namespace StudentsManager.Mvc.Services.Tests
{
    public interface ITestsService
    {
        Task<TestViewModel> GetTestAsync(Guid topicId, Guid userId);
    }
}