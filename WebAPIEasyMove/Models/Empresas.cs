using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEasyMove.Models
{
    [Table("EMPRESAS")]
    public class Empresas
    {
        [Key]
        [Column("ID_EMPRESA")]
        public int IdEmpresa { get; set; }

        [Column("NOME_EMPRESA")]
        public String NomeEmpresa { get; set; }

        [Column("CNPJ")]
        public String CNPJ { get; set; }

        [Column("AVALIACAO")]
        public String Avaliacao { get; set; }

        [Column("IMAGEM")]
        public string Imagem { get; set; }

    }
}
