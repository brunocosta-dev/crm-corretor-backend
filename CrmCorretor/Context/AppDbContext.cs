
using CrmCorretor.Models.Usuarios;
using Microsoft.EntityFrameworkCore;

namespace CrmCorretor.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Cargo> Cargos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Equipe>()
                .HasOne(e => e.Gerente)
                .WithMany()
                .HasForeignKey("GerenteId")
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
            // Configurações adicionais do modelo, se necessário
        }
    }
}