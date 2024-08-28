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
        public List<MessageDto> Get()
        {
            _messageHandler.GetMessage();
            return new List<MessageDto>();
        }
    }
}
