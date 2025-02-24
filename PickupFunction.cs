using System.Text.Json;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;
using ConsoleAPI1;
using System.Runtime.InteropServices.JavaScript;

namespace AzureFTimer;


//--- file: DailyPickupFunction.cs -----------
public class PickupFunction
{
    private readonly ILogger<PickupFunction> _logger;

    public PickupFunction(ILogger<PickupFunction> logger)
    {
        _logger = logger;
    }

    [Function("pickupfun8765")]
    public async Task Run([TimerTrigger("0 */1 * * * *")] TimerInfo timer)
    {
        _logger.LogInformation($"Function started at: {DateTime.UtcNow}");
        //Main action in Function

        EmailService cEmail = new();
        cEmail.InitMyMailSender();
        await cEmail.SendEmailTestAsync();

        _logger.LogInformation($"e-mail subiect: {cEmail._Subject}");
        _logger.LogInformation($"e-mail body: {cEmail._HtmlBody}");
    }
}
