using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldCup.Domain.Entities;

namespace WorldCup.Infra.Data.EntitiesConfiguration
{
    public class FootballClubConfiguration : IEntityTypeConfiguration<FootballClub>
    {
        public void Configure(EntityTypeBuilder<FootballClub> builder)
        {
            builder.HasKey(i => i.Id);

            builder.Property(c => c.Country).HasMaxLength(50).IsRequired();

            builder.Property(im => im.Country).HasMaxLength(300);



        }
    }
}
