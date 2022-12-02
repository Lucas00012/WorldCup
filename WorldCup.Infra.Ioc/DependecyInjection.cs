using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldCup.Domain.Interfaces;
using WorldCup.Infra.Data.Context;
using WorldCup.Infra.Data.Repositories;

namespace WorldCup.Infra.Ioc
{
    public static class DependecyInjection
    {

        public static IServiceCollection AddInfrastruture(this IServiceCollection services, 
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => 
            options.UseSqlServer(configuration.GetConnectionString("WorldCupConnection"), b => b
                .MigrationsAssembly(typeof(ApplicationDbContext)
                .Assembly.FullName)));

            services.AddScoped<ICupTitleRepository, CupTitleRepository>();
            services.AddScoped<IFootballClubRepository, FootballClubRepository>();

            return services;

        }
    }
}
