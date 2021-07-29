using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiProdutos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //property with the data who get passsed me by the whatssap
            //propriedades que foi passadas para mim pelo whatssap

            modelBuilder.Entity<Produto>().Property(p => p.Descricao).HasMaxLength(80);

            //I put the max of length by myself no wondering what type of product is but is relative and editable.

            modelBuilder.Entity<Produto>().Property(p => p.Preco).HasPrecision(15, 2);


        }
    }
}
