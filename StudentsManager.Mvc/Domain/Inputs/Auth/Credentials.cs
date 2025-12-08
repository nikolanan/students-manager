using System.ComponentModel.DataAnnotations;

namespace StudentsManager.Mvc.Domain.Inputs.Auth
{
    public class Credentials
    {
        [Required] [EmailAddress] public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}