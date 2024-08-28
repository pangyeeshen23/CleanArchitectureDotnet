using Domain.Entities;
using Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly DbContext _dbContext;
        public MessageRepository()
        {
            
        }
        public Task<Message> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
