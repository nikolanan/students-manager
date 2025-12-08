namespace StudentsManager.Mvc.Services.Options
{
    public interface IUserAnswersService
    {
        Task AddAsync(Guid userId, int questionOptionId);
    }
}