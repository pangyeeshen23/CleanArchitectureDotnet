using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class MessageRepository : IMessageRepository
    {
        private readonly MyDbContext _dbContext;
        public MessageRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Message>> GetAllAsync()
        {
            return await _dbContext.Messages.ToListAsync();
        }
    }
}
