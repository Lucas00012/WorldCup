using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using WorldCup.Application.Interfaces;
using WorldCup.Application.Mappings;
using WorldCup.Application.Services;
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
            options.UseSqlServer(configuration.GetConnectionString("WorldCupDbConnection"), b => b
                .MigrationsAssembly(typeof(ApplicationDbContext)
                .Assembly.FullName)));

            services.AddScoped<ICupTitleRepository, CupTitleRepository>();
            services.AddScoped<IFootballClubRepository, FootballClubRepository>();
            services.AddScoped<ICupTitleService, CupTitleService>();
            services.AddScoped<IFootballClubService, FootballClubService>();
            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));

            return services;

        }
    }
}
