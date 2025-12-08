using System.Security.Claims;

namespace StudentsManager.Mvc.Services.Auth
{
    public interface IPrincipalService
    {
        bool IsSignedInByClaimsPrincipal(ClaimsPrincipal principal);
        Guid GetUserIdByClaimsPrincipal(ClaimsPrincipal principal);
    }
}