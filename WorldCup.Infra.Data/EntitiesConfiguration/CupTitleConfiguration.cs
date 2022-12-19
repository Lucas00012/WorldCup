using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WorldCup.Domain.Entities;

namespace WorldCup.Infra.Data.EntitiesConfiguration
{
    public class CupTitleConfiguration : IEntityTypeConfiguration<CupTitle>
    {
        public void Configure(EntityTypeBuilder<CupTitle> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(l => l.Location).HasMaxLength(50).IsRequired();

            builder
                .HasOne(f => f.ChampionFootballClub)
                .WithMany(c => c.CupTitles)
                .HasForeignKey(fk => fk.ChampionFootballClubId);

            builder.HasData(
                new CupTitle(1, 1930, "Uruguay"),
                new CupTitle(2, 2014, "Brazil"),
                new CupTitle(3, 2022, "Qatar")
                );

        }
    }
}
