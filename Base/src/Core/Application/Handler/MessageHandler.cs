using Domain.Entities;
using Domain.Repositories;

namespace Application.Handler
{
    public class MessageHandler : IMessageHandler
    {
        private readonly IMessageRepository _messageRepository;
        public MessageHandler(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public async Task<Message> GetMessage()
        {
            return await _messageRepository.GetByIdAsync(1);
        }
    }
}
