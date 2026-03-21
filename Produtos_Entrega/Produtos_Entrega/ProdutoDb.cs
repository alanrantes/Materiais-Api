using Microsoft.EntityFrameworkCore;
using Produtos_Entrega;
using System.Reflection.Emit;

namespace Produtos_Entrega
{
    public class ProdutoDb : DbContext
    {
        public ProdutoDb(DbContextOptions<ProdutoDb> options)
            : base(options) { }
        public DbSet<Produto> Produtos => Set<Produto>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(10, 2);
        }
    }
}
