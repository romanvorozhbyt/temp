using DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.EF
{
    class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
    {
        public void Configure(EntityTypeBuilder<Publisher> builder)
        {
            builder.HasMany(p => p.Games)
                  .WithOne(g => g.Publisher);

            builder.HasIndex(p => p.Key)
                 .IsUnique();

        }
    }
}
