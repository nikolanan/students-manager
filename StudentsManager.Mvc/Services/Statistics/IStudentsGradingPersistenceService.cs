using StudentsManager.Mvc.Domain.Views.Statistics;

namespace StudentsManager.Mvc.Services.Statistics
{
    public interface IStudentsGradingPersistenceService
    {
        Task SaveAsync(IReadOnlyList<StudentGrade> grades);
    }
}