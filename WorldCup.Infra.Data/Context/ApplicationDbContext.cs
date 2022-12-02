using Microsoft.EntityFrameworkCore;
using WorldCup.Domain.Entities;

namespace WorldCup.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        { }

        public DbSet<FootballClub> FootballClubs { get; set; }

        public DbSet<CupTitle> CupTitles { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }


    }
}
