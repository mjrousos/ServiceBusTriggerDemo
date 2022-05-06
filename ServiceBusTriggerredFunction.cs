using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace DemoProject
{
    public static class ServiceBusTriggerredFunction
    {
        [FunctionName("ServiceBusTriggerredFunction")]
        public static void Run([ServiceBusTrigger("inputqueue", Connection = "myconnectionstring")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
