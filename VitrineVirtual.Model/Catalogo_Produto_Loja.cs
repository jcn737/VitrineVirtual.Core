using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineVirtual.Model
{
    [Table("Catalogo_Produtos_Loja")]
    public class Catalogo_Produto_Loja
    {
        [Key]
        public int ID_Catalogo_Prod_Loja { get; set; }
    }
}
