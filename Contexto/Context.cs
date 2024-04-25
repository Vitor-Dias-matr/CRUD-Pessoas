using CadastroPessoas.Models;
using Microsoft.EntityFrameworkCore;

namespace CadastroPessoas.Contexto
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> option): base(option)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(e => e.TipoPessoa)
                .HasConversion<int>(); // Converte o enum para int
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}
