using System.Text;
using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.Clicks
{
    public class ExaminationAnswersService : IExaminationAnswersService
    {
        private readonly ManagerDbContext _dbContext;

        public ExaminationAnswersService(ManagerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ExaminationAnswer> GetByIdAsync(Guid id)
        {
            var entity = await _dbContext
                .ExaminationAnswers
                .Include(answer => answer.User)
                .FirstOrDefaultAsync(answer => answer.Id == id);

            if (entity == null) throw new NullReferenceException();

            return entity;
        }

        public async Task<ExaminationAnswer> MarkSuccessAsync(ExaminationAnswer examinationAnswer)
        {
            examinationAnswer.WasSuccessfullyProcessed = true;
            examinationAnswer.ErrorMessage = null;

            _dbContext.Update(examinationAnswer);
            await _dbContext.SaveChangesAsync();
            return examinationAnswer;
        }

        public async Task<ExaminationAnswer> MarkFailAsync(ExaminationAnswer examinationAnswer, Exception exception)
        {
            examinationAnswer.WasSuccessfullyProcessed = false;

            var errorBuilder = new StringBuilder();
            errorBuilder.Append($"Exception: {exception.Message}||");
            errorBuilder.Append($"InnerException: {exception.InnerException}||");
            errorBuilder.Append($"Source: {exception.Source}||");
            errorBuilder.Append($"StackTrace: {exception.StackTrace}");

            examinationAnswer.ErrorMessage = errorBuilder.ToString();

            _dbContext.Update(examinationAnswer);
            await _dbContext.SaveChangesAsync();
            return examinationAnswer;
        }
    }
}