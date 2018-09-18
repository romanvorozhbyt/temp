using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EF
{
    class GamePlatformConfiguration : IEntityTypeConfiguration<GamePlatform>
    {
        public void Configure(EntityTypeBuilder<GamePlatform> builder)
        {
            builder.HasKey(k => new { k.GameId, k.PlatformId});

            builder.HasOne(gg => gg.Game)
                .WithMany(g => g.GamePlatforms)
                .HasForeignKey(gg => gg.GameId);

            builder.HasOne(gg => gg.Platform)
                .WithMany(g => g.GamePlatforms)
                .HasForeignKey(gg => gg.PlatformId);
        }
    }
}
