using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineVirtual.Model
{
    [Table("Cadastro_Produto_Loja")]
    public class Cadastro_Produto_Loja
    {
        [Key]
        public int ID_Cadastro_Prod_Loja { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        public string Nome_Produto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]

        public string Modelo_Produto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.MultilineText)]
        public string Descricao_Produto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Currency)]
        //[DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public decimal Preco_Produto { get; set; }

        [Required(ErrorMessage = "Campo Obrigatório")]
        [DataType(DataType.Currency)]
        public int Quantidade_Produto { get; set; }

        public string Categoria_Produto { get; set; }

        public string Grupo_Produto { get; set; }

        public string Status_Produto { get; set; }

        [DataType(DataType.Upload)]
        public byte?[] Foto_Produto_1 { get; set; }

        public byte?[] Foto_Produto_2 { get; set; }

        public byte?[] Foto_Produto_3 { get; set; }

        public byte?[] Foto_Produto_4 { get; set; }

        public byte?[] Foto_Produto_5 { get; set; }


        public virtual ICollection<FilePath> FilePath { get; set; }


    }
}


