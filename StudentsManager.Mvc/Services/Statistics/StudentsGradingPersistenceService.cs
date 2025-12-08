using System.Text;
using StudentsManager.Mvc.Domain.Views.Statistics;
using StudentsManager.Mvc.Services.Storage;

namespace StudentsManager.Mvc.Services.Statistics
{
    public class StudentsGradingPersistenceService : IStudentsGradingPersistenceService
    {
        private readonly IStorageService _storageService;

        public StudentsGradingPersistenceService(IStorageService storageService)
        {
            _storageService = storageService;
        }

        public Task SaveAsync(IReadOnlyList<StudentGrade> grades)
        {
            var builder = new StringBuilder();
            builder.AppendLine("student name; student faculty; points;");
            foreach (var studentGrade in grades)
                builder.AppendLine(
                    $"{studentGrade.StudentName}; {studentGrade.StudentFacultyNumber}; {studentGrade.Total}");

            return _storageService.UploadToContainerAsync(
                "38dcc3f0-e480-4aee-0ab9-08d8a6c81957",
                new MemoryStream(Encoding.UTF8.GetBytes(builder.ToString())),
                $"studentGrade-{Guid.NewGuid()}.csv");
        }
    }
}