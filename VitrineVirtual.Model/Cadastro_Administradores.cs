﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VitrineVirtual.Model
{
    [Table("Cadastro_Administradores")]
    public class Cadastro_Administradores
    {
        [Key]
        public int ID_Cadastro_Adm { get; set; }
    }
}
