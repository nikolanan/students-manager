using System.ComponentModel.DataAnnotations;

namespace StudentsManager.Mvc.Domain.Inputs.Auth;

public class ResetPassword
{
    [Required]
    [EmailAddress] 
    public string Email { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }

    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
    public string ConfirmPassword { get; set; }
}