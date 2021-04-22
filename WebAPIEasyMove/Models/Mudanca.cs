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
        [Column("IDMUDANCA")]
        public int IdMudanca { get; set; }

        [Column("TICKETNUMBER")]
        public int TicketNumber { get; set; }

        [Column("NOMEUSUARIO")]
        public String NomeUsuario { get; set; }

        [Column("NOMEEMPRESA")]
        public String NomeEmpresa { get; set; }

        [Column("CNPJ")]
        public long CNPJ { get; set; }

        [Column("ROTA")]
        public String Rota { get; set; }

        [Column("AGENDAMENTO")]
        public String Agendamento { get; set; }

        [Column("VALOR")]
        public int Valor { get; set; }

        public Mudanca()
        {
        }

        public Mudanca(int idMudanca, int ticketNumber, string nomeUsuario, string nomeEmpresa, int cNPJ, string rota, string agendamento, int valor)
        {
            IdMudanca = idMudanca;
            TicketNumber = ticketNumber;
            NomeUsuario = nomeUsuario;
            NomeEmpresa = nomeEmpresa;
            CNPJ = cNPJ;
            Rota = rota;
            Agendamento = agendamento;
            Valor = valor;
        }
    }
}
