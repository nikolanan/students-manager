using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentsManager.Mvc.Configurations;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Inputs.Students;
using StudentsManager.Mvc.Domain.Views.Students;
using StudentsManager.Mvc.Persistence;

namespace StudentsManager.Mvc.Services.Students
{
    public class StudentsService(ManagerDbContext dbContext, UserManager<User> userManager) : IStudentsService
    {
        public async Task<List<StudentView?>> AllAsync() => 
            (await dbContext
                .Users
                .Where(user => user.IsDeleted == false)
                .ToListAsync())
            .Select(user => user.ToView())
            .ToList();

        public async Task<StudentView?> GetByFacultyNumberAsync(string facultyNumber)
        {
            return (await dbContext
                .Users
                .FirstOrDefaultAsync(user => user.FacultyNumber == facultyNumber))
                .ToView();
        }

        public async Task<StudentView?> UpdatePictureAsync(UpdatePicture input)
        {
            var user = await GetUserByFacultyNumberAsync(input.FacultyNumber);
            if (user == null)
            {
                return null;
            }
            var isPasswordCorrect = await userManager.CheckPasswordAsync(user, input.Password);
            if (!isPasswordCorrect)
            {
                return null;
            }
            user.Base64EncodePicture = input.Picture;
            dbContext.Users.Update(user);
            await dbContext.SaveChangesAsync();

            return user.ToView();
        }

        private Task<User?> GetUserByFacultyNumberAsync(string facultyNumber) =>
            dbContext
                .Users
                .FirstOrDefaultAsync(user => user.FacultyNumber == facultyNumber);
    }
}