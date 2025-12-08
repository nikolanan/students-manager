using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Views.Cognitive;

namespace StudentsManager.Mvc.Services.Cognitive
{
    public interface ITextAnalyticService
    {
        UserAnswerReportView ProcessReport(ExaminationAnswer entity);
    }
}