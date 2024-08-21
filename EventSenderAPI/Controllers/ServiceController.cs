using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System.Text;
using RabbitMQ.Client;
using ProjectLibrary.DTOs;

namespace EventSenderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ServiceController : ControllerBase
    {
        private readonly string _hostname = "some-rabbit";
        private readonly string _queueName = "serviceQueue";
        private readonly string _username = "user";
        private readonly string _password = "password";
        private readonly ConnectionFactory _connection;

        public ServiceController()
        {
            _connection = new ConnectionFactory()
            {
                HostName = _hostname,
                UserName = _username,
                Password = _password
            };
        }

        [HttpPost("init-service")]
        public IActionResult InitService([FromBody] InitiateService inputData)
        {
            using (var connection = _connection.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: _queueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var message = JsonSerializer.Serialize(inputData);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: _queueName,
                                     basicProperties: null,
                                     body: body);

                return Ok("Service was initiated.");
            }
        }

        [HttpPost("update-service")]
        public IActionResult UpdateService([FromBody] UpdateService inputData)
        {
            using (var connection = _connection.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: _queueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var message = JsonSerializer.Serialize(inputData);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: _queueName,
                                     basicProperties: null,
                                     body: body);

                return Ok("Service finalized.");
            }
        }

        [HttpPost("finish-service")]
        public IActionResult FinishService([FromBody] FinishService inputData)
        {
            using (var connection = _connection.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: _queueName,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var message = JsonSerializer.Serialize(inputData);
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish(exchange: "",
                                     routingKey: _queueName,
                                     basicProperties: null,
                                     body: body);

                return Ok("Service finalized.");
            }
        }
    }
}
