using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Inputs.Auth;
using StudentsManager.Mvc.Mappings;
using StudentsManager.Mvc.Persistence;
using StudentsManager.Mvc.Services.Courses;
using StudentsManager.Mvc.Services.Storage;

namespace StudentsManager.Mvc.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly ManagerDbContext _dbContext;
        private readonly SignInManager<User?> _signInManager;
        private readonly IStorageService _storageService;
        private readonly UserManager<User?> _userManager;

        public AuthService(
            UserManager<User?> userManager,
            SignInManager<User?> signInManager,
            ManagerDbContext dbContext,
            IStorageService storageService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _dbContext = dbContext;
            _storageService = storageService;
        }

        public async Task<User?> LoginAsync(Credentials model)
        {
            var user = await _dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == model.Email);

            if (user == null) return null;

            var isPasswordCorrect = await _userManager.CheckPasswordAsync(user, model.Password);

            if (!isPasswordCorrect) return null;

            await _signInManager.SignInAsync(user, false);

            return user;
        }

        public async Task<User?> RegisterAsync(Register model)
        {
            var user = model.ToEntity();
            var creationResult = await _userManager.CreateAsync(user, model.Password);
            if (!creationResult.Succeeded) return null;

            var userCourse = new UserCourse
            {
                UserId = user.Id,
                CourseId = CourseSeeder.HybridMobileAppCourse.Id
            };

            await _dbContext.UserCourses.AddAsync(userCourse);
            await _dbContext.SaveChangesAsync();

            await _storageService.CreateBlobContainerByNameAsync(user.Id.ToString());

            await _signInManager.SignInAsync(user, false);

            return user;
        }

        public Task LogoutAsync()
        {
            return _signInManager.SignOutAsync();
        }

        public async Task<User?> ResetPasswordAsync(ResetPassword model)
        {
            var user = await _dbContext
                .Users
                .FirstOrDefaultAsync(u => u.Email == model.Email);

            if (user == null) return null;

            var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            var identityResult = await _userManager.ResetPasswordAsync(user, resetToken, model.Password);
            if (!identityResult.Succeeded) return null;

            await _signInManager.SignInAsync(user, false);

            return user;
        }
    }
}