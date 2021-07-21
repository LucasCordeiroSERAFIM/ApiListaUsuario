using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace restCadastro.Data
{
    public class AppDbContext:DbContext 
    {
      public  AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().Property(p => p.Nome).HasMaxLength(80);
            modelBuilder.Entity<Usuario>().Property(p => p.Email).HasMaxLength(80);
            modelBuilder.Entity<Usuario>().Property(p => p.Cargo).HasMaxLength(80);

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario { Id = 1, Nome = "Lucas Cordeiro", Cargo = "Analista de Sistemas I", Email = "Lucas.cordeiro@totvs.br" },
                new Usuario { Id = 2, Nome = "Joabe Queiroz", Cargo = "Analista de Infra I", Email = "Joabe.Queiroz@totvs.br" }
                );
        }
    }
}
