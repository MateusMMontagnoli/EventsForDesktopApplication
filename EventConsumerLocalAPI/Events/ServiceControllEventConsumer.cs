using Microsoft.AspNetCore.Mvc.Diagnostics;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using ProjectLibrary.DTOs;
using EventConsumerLocalAPI.Hubs;

namespace EventConsumerLocalAPI.Events;

public class ServiceControllEventConsumer : IHostedService
{
    private readonly string _hostname = "localhost"; // DNS dinâmico ou IP público
    private readonly string _queueName = "serviceQueue";
    private IConnection _connection;
    private IModel _channel;
    private readonly ServiceSender _serviceSender;

    public ServiceControllEventConsumer(ServiceSender serviceSender)
    {
        _serviceSender = serviceSender;
    }

    public Task StartAsync(CancellationToken cancellationToken)
    {
        var factory = new ConnectionFactory()
        {
            HostName = _hostname,
            Port = 5672,
            UserName = "user",
            Password = "password"
        };

        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();

        _channel.QueueDeclare(queue: _queueName,
                             durable: false,
                             exclusive: false,
                             autoDelete: false,
                             arguments: null);

        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetString(body);
            var eventData = JsonConvert.DeserializeObject<ServiceOutput>(message);

            ProcessEvent(eventData);
        };

        _channel.BasicConsume(queue: _queueName,
                             autoAck: true,
                             consumer: consumer);

        return Task.CompletedTask;
    }

    private async void ProcessEvent(ServiceOutput eventData)
    {
        await _serviceSender.SendDashboardUpdate(new List<ServiceOutput>() { eventData });
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _channel.Close();
        _connection.Close();
        return Task.CompletedTask;
    }
}
