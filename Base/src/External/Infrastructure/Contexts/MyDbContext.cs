using Domain.Entities;
using Microsoft.EntityFrameworkCore;
namespace Infrastructure.Context
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }
        public DbSet<Message> Messages { get; set; }
    }
}
