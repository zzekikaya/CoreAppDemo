using System;
using System.Collections.Generic;
using System.Text;
using CoreApp.Domain;
using Microsoft.EntityFrameworkCore;

namespace CoreApp.Data
{
    public class SamuraiContext:DbContext
    {
        public SamuraiContext(DbContextOptions<SamuraiContext> options)
            : base(options)
        { }
        //add-migration name
        //after
        //update-database
        public DbSet<Samurai> Samurais { get; set; }
        public DbSet<Quote> Quotes { get; set; }
        public DbSet<Battle> Battles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SamuraiBattle>()
                .HasKey(s => new { s.BattleId, s.SamuraiId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
