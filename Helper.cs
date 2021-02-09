using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Azure.Messaging.ServiceBus;
using Microsoft.Extensions.Logging;

namespace publisher
{
    public static class ServiceBusEngine
    {
        static string ConnectionString = "Endpoint=sb://credrails.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=+ioiZiRmr/D4CnaUcZVIyHbVZEUTsgpNQ0+l54+Wvi4=";
        public static async Task SendMessageToTopicAsync(string body, string topic)
        {
            // create a Service Bus client 
            await using (ServiceBusClient client = new ServiceBusClient(ConnectionString))
            {
                // create a sender for the topic
                ServiceBusSender sender = client.CreateSender(topic);
                await sender.SendMessageAsync(new ServiceBusMessage(body));
                //_logger.LogInformation($"Sent {body} to: {topic}");
            }
        }
    }
}