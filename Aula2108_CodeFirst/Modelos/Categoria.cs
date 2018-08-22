using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2108_CodeFirst.Modelos
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        
        [Required]
        [StringLength(30)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        //Relacionamento Categoria <--> Produto

        public virtual ICollection<Produto> _ProdutosT { get; set; }
    }
}
