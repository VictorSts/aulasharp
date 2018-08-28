using System.Data.Entity;

namespace Aula2108_CodeFirst.Modelos.DAL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("nomeStringConexao")
        {
             
        }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }


    }
}
/**
String conexão

         -nome
         -Data Source (servidor)
String   -Initial Catalog (base de dados)
         -Integrated Security=True
     
*/
