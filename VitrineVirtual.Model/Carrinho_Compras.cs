using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineVirtual.Model
{
    [Table("Carrinho_Compras")]
    public class Carrinho_Compras
    {
        [Key]
        public int ID_Carrinho_Compras{ get; set; }
    }
}
