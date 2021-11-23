using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEasyMove.Models
{
    [Table("MUDANCA")]
    public class Mudanca
    {
        [Key]
        [Column("ID_MUDANCA")]
        public int IdMudanca { get; set; }

        [Column("NM_EMPRESA")]
        public String nmEmpresa { get; set; }

        [Column("TIPO_CAMINHAO")]
        public String tpCaminhao { get; set; }

        [Column("LOGRADOURO")]
        public String logradouro { get; set; }

        [Column("NUMERO")]
        public int numero { get; set; }
        
        public Mudanca()
        {
        }

        public Mudanca(int IdMudanca, string nmEmpresa, string tpCaminhao, string logradouro, string numero)
        {
            idmudanca = IdMudanca;
            nmempresa = nmEmpresa;
            tpcaminhao = tpCaminhao;
            Logradouro = logradouro;
            Numero = numero;
        }
    }
}
