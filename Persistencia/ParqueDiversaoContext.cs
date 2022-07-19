using Exp3.Models;
using Microsoft.EntityFrameworkCore;

namespace Exp3.Persistencia
{
    public class ParqueDiversaoContext : DbContext
    {
        public DbSet<Brinquedo> Brinquedos { get; set; }
        public DbSet<Colaborador> Colaboradores { get; set; }
        public DbSet<ContratoTrabalho> ContratosTrabalhos { get; set; }
        public DbSet<BrinquedoColaborador> BrinquedosColaboradores { get; set; }
        public DbSet<Manutencao> Manutencoes { get; set; }


        public ParqueDiversaoContext(DbContextOptions op) : base(op) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configurar a chave composta da associativa
            modelBuilder.Entity<BrinquedoColaborador>().HasKey(bc => new { bc.BrinquedoId, bc.ColaboradorId, bc.Data });

            //Configurar relacionamento da associativa com Brinquedo
            modelBuilder.Entity<BrinquedoColaborador>()
                .HasOne(bc => bc.Brinquedo)
                .WithMany(bc => bc.BrinquedosColaboradores)
                .HasForeignKey(bc => bc.BrinquedoId);

            //Configurar relacionamento da associativa com Brinquedo
            modelBuilder.Entity<BrinquedoColaborador>()
                .HasOne(bc => bc.Colaborador)
                .WithMany(bc => bc.BrinquedosColaboradores)
                .HasForeignKey(bc => bc.ColaboradorId);

            base.OnModelCreating(modelBuilder);

        }
    }
}
