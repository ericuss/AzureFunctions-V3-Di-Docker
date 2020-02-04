using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Lanre.Func
{
    public static class GetMessage
    {
        [FunctionName("GetMessage")]
        public static void Run([QueueTrigger("queue-messages", Connection = "Storage")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
