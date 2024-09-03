using Application.Handler;
using Microsoft.AspNetCore.Mvc;
using Presentation.Dtos;

namespace Presentation.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MessageController
    {
        IMessageHandler _messageHandler;
        public MessageController(IMessageHandler messageHandler)
        {
            _messageHandler = messageHandler;
        }

        [HttpGet]
        public async Task<List<MessageDto>> GetAll()
        {
            var message = await _messageHandler.GetMessages();

            return new List<MessageDto>()
            {
                new MessageDto() {
                    Id = message.First().Id,
                    Title = message.First().Title,
                    Message = message.First().Body,
                }
            };
        }
    }
}
