using Microsoft.EntityFrameworkCore;
using PortrasDasApostas.Core.Models;

namespace PortrasDasApostas.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Bet> Bets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bet>()
                .Property(b => b.Amount)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Bet>()
                .Property(b => b.Odds)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Bet>()
                .Property(b => b.PotentialWinnings)
                .HasColumnType("decimal(18,2)");
        }
    }
}