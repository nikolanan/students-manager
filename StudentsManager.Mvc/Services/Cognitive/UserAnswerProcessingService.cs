using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Azure;
using Microsoft.Extensions.Options;
using StudentsManager.Mvc.Domain.Inputs.Messaging;
using StudentsManager.Mvc.Services.Clicks;
using StudentsManager.Mvc.Services.Messaging;
using StudentsManager.Mvc.Settings;

namespace StudentsManager.Mvc.Services.Cognitive
{
    public class UserAnswerProcessingService : BackgroundService
    {
        private readonly IAzureClientFactory<ServiceBusClient> _azureServiceBusClientFactory;
        private readonly IMailService _mailService;
        private readonly ServiceBusSettings _serviceBusSettings;
        private readonly IServiceScopeFactory _serviceScopeFactory;
        private readonly ITextAnalyticService _textAnalyticService;

        public UserAnswerProcessingService(
            IOptions<ServiceBusSettings> options,
            IServiceScopeFactory serviceScopeFactory,
            IAzureClientFactory<ServiceBusClient> azureServiceBusClientFactory,
            IMailService mailService,
            ITextAnalyticService textAnalyticService)
        {
            _serviceScopeFactory = serviceScopeFactory ?? throw new ArgumentNullException(nameof(serviceScopeFactory));
            _azureServiceBusClientFactory = azureServiceBusClientFactory ??
                                            throw new ArgumentNullException(nameof(azureServiceBusClientFactory));
            _mailService = mailService;
            _textAnalyticService = textAnalyticService ?? throw new ArgumentNullException(nameof(ITextAnalyticService));
            _serviceBusSettings = options.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            // Create the client object that will be used to create sender and receiver objects
            var client = _azureServiceBusClientFactory.CreateClient("DefaultServiceBus");

            // create a processor that we can use to process the messages
            var processor = client.CreateProcessor(_serviceBusSettings.QueueName);
            try
            {
                // add handler to process messages
                processor.ProcessMessageAsync += MessageHandlerAsync;

                // add handler to process any errors
                processor.ProcessErrorAsync += ErrorHandlerAsync;

                // start processing 
                await processor.StartProcessingAsync(stoppingToken);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        // handle received messages
        private async Task MessageHandlerAsync(ProcessMessageEventArgs args)
        {
            var body = args.Message.Body.ToString();
            var parseResult = Guid.TryParse(body, out var key);
            if (!parseResult) Console.WriteLine($"Received: {body}. Could not be parsed to GUID.");

            // execute the process
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var examinationAnswersService =
                    scope.ServiceProvider.GetRequiredService<IExaminationAnswersService>() ??
                    throw new ArgumentNullException($"{nameof(IExaminationAnswersService)}");
                var examinationAnswer = await examinationAnswersService.GetByIdAsync(key);
                try
                {
                    var reportView = _textAnalyticService.ProcessReport(examinationAnswer);

                    var mailRequest = new MailRequest
                    {
                        ToEmail = reportView.UserMail,
                        Subject = "Students Manager Examination Results",
                        Body = reportView.Report
                    };

                    await _mailService.SendEmailAsync(mailRequest);
                    await examinationAnswersService.MarkSuccessAsync(examinationAnswer);
                }
                catch (Exception e)
                {
                    await examinationAnswersService.MarkFailAsync(examinationAnswer, e);
                    await _mailService.SendProblem(e);
                    throw;
                }
            }

            // complete the message. messages is deleted from the queue. 
            await args.CompleteMessageAsync(args.Message);
        }

        // handle any errors when receiving messages
        private static Task ErrorHandlerAsync(ProcessErrorEventArgs args)
        {
            Console.WriteLine(args.Exception.ToString());
            return Task.CompletedTask;
        }
    }
}