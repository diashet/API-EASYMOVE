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
        [Column("id_mudanca")]
        public int IdMudanca { get; set; }

        [Column("nm_empresa")]
        public String nmEmpresa { get; set; }

        [Column("tipo_caminhao")]
        public String tpCaminhao { get; set; }

        [Column("logradouro")]
        public String logradouro { get; set; }

        [Column("numero")]
        public long numero { get; set; }

        public Mudanca()
        {
        }
        public Mudanca(int idMudanca, string nmEmpresa, string tpCaminhao, string logradouro, long numero)
        {
            IdMudanca = idMudanca;
            this.nmEmpresa = nmEmpresa;
            this.tpCaminhao = tpCaminhao;
            this.logradouro = logradouro;
            this.numero = numero;
        }
    }
}
