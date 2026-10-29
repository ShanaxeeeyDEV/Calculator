using Calculator.Models.Auth;
using Calculator.Models.Financeiro;
using Microsoft.EntityFrameworkCore;

namespace Calculator.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users { get; set; } = default;
        public DbSet<Despesa> Despesas { get; set; } = default;
        public DbSet<Investimento> Investimentos { get; set; } = default;
        public DbSet<Investimento> Contas { get; set; } = default;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Despesa>()
                .HasOne(d => d.Conta)
                .WithMany(u => u.Despesas)
                .HasForeignKey(d => d.Conta.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}