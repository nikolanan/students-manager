using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Inputs.Auth;

namespace StudentsManager.Mvc.Services.Auth
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(Credentials model);

        Task<User?> RegisterAsync(Register model);

        Task LogoutAsync();

        Task<User?> ResetPasswordAsync(ResetPassword model);
    }
}