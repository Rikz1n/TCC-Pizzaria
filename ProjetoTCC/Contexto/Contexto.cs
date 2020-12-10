using Microsoft.EntityFrameworkCore;
using ProjetoTCC.Models;

namespace ProjetoTCC
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> op):base(op)
        {

        }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }

    }
}
