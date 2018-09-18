using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Text;
using DAL.Models;

namespace DAL.EF
{
    class GameStoreContext : DbContext
    {
        public GameStoreContext(DbContextOptions<GameStoreContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new GameConfiguration());
            builder.ApplyConfiguration(new GameGenreConfiguration());
            builder.ApplyConfiguration(new GamePlatformConfiguration());
            builder.ApplyConfiguration(new PublisherConfiguration());
           
            builder.Entity<Genre>()
                 .HasIndex(g => g.Name)
                 .IsUnique();

            builder.Entity<PlatformType>()
                 .HasIndex(p => p.Name)
                 .IsUnique();
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<PlatformType> Platforms { get; set; }

    }
}
