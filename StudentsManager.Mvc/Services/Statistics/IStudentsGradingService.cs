using StudentsManager.Mvc.Domain.Views.Statistics;

namespace StudentsManager.Mvc.Services.Statistics
{
    public interface IStudentsGradingService
    {
        Task<IReadOnlyList<StudentGrade>> GetAsync();
    }
}