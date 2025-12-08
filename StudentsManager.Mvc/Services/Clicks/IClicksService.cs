using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Inputs.Click;

namespace StudentsManager.Mvc.Services.Clicks
{
    public interface IClicksService
    {
        object GetQuestionsContent(string type);

        Task SaveAndPublishAnswersAsync(ClickResultsRootObject rootObject, Guid userId, string questionsContentType);

        Task<ExaminationAnswer> SaveAnswersAsync(ClickResultsRootObject rootObject, Guid userId,
            string questionsContentType);
    }
}