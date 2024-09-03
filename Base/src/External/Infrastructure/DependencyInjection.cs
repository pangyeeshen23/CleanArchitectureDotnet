using Domain.Repositories;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure
{
    public static class DependencyInjection
    {

        public static IServiceCollection AddInfrastructure (this IServiceCollection services)
        {
            services.AddScoped<IMessageRepository, MessageRepository>();
            //services.AddDbContext<DbContext>(options =>
            //    options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
