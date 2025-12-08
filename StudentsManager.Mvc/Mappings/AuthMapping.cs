using System.Net.Mail;
using StudentsManager.Mvc.Domain.Entities;
using StudentsManager.Mvc.Domain.Inputs.Auth;

namespace StudentsManager.Mvc.Mappings
{
    public static class AuthMapping
    {
        public static User ToEntity(this Register model)
        {
            var rnd = new Random();
            return new User
            {
                Email = model.Email,
                UserName = $"{new MailAddress(model.Email).User}{rnd.Next(0, 100)}",
                FullName = model.FullName,
                FacultyNumber = model.FacultyNumber,
                EmailConfirmed = true,
                CreatedOn = DateTime.UtcNow,
                IsDeleted = false
            };
        }
    }
}