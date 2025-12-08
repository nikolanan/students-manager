namespace StudentsManager.Mvc.Domain.Views.Students
{
    public readonly record struct StudentView(string? UserName, string? Email, string FullName, string FacultyNumber, string? Base64EncodePicture);
}