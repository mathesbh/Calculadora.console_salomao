using Application.Models;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class CalculadoraDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=127.0.0.1,1433;Database=calculadora_frwk;User ID=sa;Password=1q2w3e4r@#$");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CalculadoraDbContext).Assembly);
        }

        public DbSet<OperacoesHistorico> OperacoesHistoricos { get; set; }
    }
}