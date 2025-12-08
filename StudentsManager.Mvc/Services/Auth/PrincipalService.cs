using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using StudentsManager.Mvc.Domain.Entities;

namespace StudentsManager.Mvc.Services.Auth
{
    public class PrincipalService : IPrincipalService
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;

        public PrincipalService(UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        public bool IsSignedInByClaimsPrincipal(ClaimsPrincipal principal)
        {
            return _signInManager.IsSignedIn(principal);
        }

        public Guid GetUserIdByClaimsPrincipal(ClaimsPrincipal principal)
        {
            var userId = _userManager.GetUserId(principal);
            return userId == null ? throw new ArgumentNullException(nameof(userId)) : Guid.Parse(userId);
        }
    }
}