using Domain.Entities;

namespace Application.Handler
{
    public interface IMessageHandler
    {
        public Task<Message> GetMessage();
    }
}
