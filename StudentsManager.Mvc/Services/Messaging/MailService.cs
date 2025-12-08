using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using StudentsManager.Mvc.Domain.Inputs.Messaging;
using StudentsManager.Mvc.Settings;

namespace StudentsManager.Mvc.Services.Messaging
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;

        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }

        public Task SendProblem(Exception exception)
        {
            var mailRequest = new MailRequest
            {
                ToEmail = _mailSettings.Mail,
                Subject = "ERROR Students Manager Examination Results",
                Body = exception.Message
            };

            return SendEmailAsync(mailRequest);
        }

        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            try
            {
                var email = new MimeMessage
                {
                    Sender = MailboxAddress.Parse(_mailSettings.Mail)
                };

                email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
                email.Subject = mailRequest.Subject;

                var builder = new BodyBuilder
                {
                    HtmlBody = mailRequest.Body
                };
                email.Body = builder.ToMessageBody();

                using var smtp = new SmtpClient();
                await smtp.ConnectAsync(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
                await smtp.AuthenticateAsync(_mailSettings.Mail, _mailSettings.Password);
                await smtp.SendAsync(email);
                await smtp.DisconnectAsync(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}