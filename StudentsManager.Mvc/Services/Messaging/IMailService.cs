using StudentsManager.Mvc.Domain.Inputs.Messaging;

namespace StudentsManager.Mvc.Services.Messaging
{
    public interface IMailService
    {
        Task SendProblem(Exception exception);
        Task SendEmailAsync(MailRequest mailRequest);
    }
}