using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Options;
using StudentsManager.Mvc.Settings;

namespace StudentsManager.Mvc.Services.Messaging
{
    public class AzureServiceBusSender : IAzureServiceBusSender
    {
        private readonly IAzureClientFactory<ServiceBusClient> _azureServiceBusClientFactory;
        private readonly ServiceBusSettings _settings;

        public AzureServiceBusSender(IAzureClientFactory<ServiceBusClient> azureServiceBusClientFactory,
            IOptions<ServiceBusSettings> options)
        {
            _azureServiceBusClientFactory = azureServiceBusClientFactory;
            _settings = options.Value;
        }

        public async Task SendAsync(string body)
        {
            var serviceBusClient = _azureServiceBusClientFactory.CreateClient("DefaultServiceBus");
            var serviceBusSender = serviceBusClient.CreateSender(_settings.QueueName);
            await serviceBusSender.SendMessageAsync(new ServiceBusMessage(body));
        }
    }
}