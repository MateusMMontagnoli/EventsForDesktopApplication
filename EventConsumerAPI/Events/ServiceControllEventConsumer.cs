using Microsoft.AspNetCore.Mvc.Diagnostics;
using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using Newtonsoft.Json;
using EventConsumerAPI.DTOs;

namespace EventConsumerAPI.Events;

public class ServiceControllEventConsumer : IHostedService
{
    private readonly string _hostname = "meuservidor.dyndns.org"; // DNS dinâmico ou IP público
    private readonly string _queueName = "event_queue";
    private IConnection _connection;
    private IModel _channel;

    public Task StartAsync(CancellationToken cancellationToken)
    {
        var factory = new ConnectionFactory()
        {
            HostName = _hostname,
            Port = 5671, // Porta segura para SSL/TLS
            Ssl = new SslOption
            {
                Enabled = true,
                ServerName = _hostname // Nome do servidor para validação SSL
            }
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
            var eventData = JsonConvert.DeserializeObject<EventData>(message);

            // Processa o evento recebido
            ProcessEvent(eventData);
        };

        _channel.BasicConsume(queue: _queueName,
                             autoAck: true,
                             consumer: consumer);

        return Task.CompletedTask;
    }

    private void ProcessEvent(EventData eventData)
    {

        Console.WriteLine($"Evento Recebido: ");
        // Lógica para processar o evento
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        _channel.Close();
        _connection.Close();
        return Task.CompletedTask;
    }
}
