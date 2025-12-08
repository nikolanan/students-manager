namespace StudentsManager.Mvc.Services.Messaging
{
    public interface IAzureServiceBusSender
    {
        Task SendAsync(string body);
    }
}