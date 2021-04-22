using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIEasyMove.Models
{
    [Table("PAGAMENTO")]
    public class Pagamento
    {
        [Key]
        [Column("IDPAGAMENTO")]
        public int IdPagamento { get; set; }

        [Column("DESCRICAO")]
        public String Descricao { get; set; }

        [Column("NOMEUSUARIO")]
        public String NomeUsuario { get; set; }

        [Column("CPF")]
        public long CPF { get; set; }

        [Column("NUMEROCARTAO")]
        public long NumeroCartao { get; set; }

        [Column("CODIGOSEGURANCA")]
        public int CodigoSeguranca { get; set; }

        [Column("BANCO")]
        public String Banco { get; set; }

        [Column("DATAPAGAMENTO")]
        public String DataPagamento { get; set; }


        public Pagamento()
        {
        }

        public Pagamento(int idPagamento, string descricao, string nomeUsuario, int cPF, int numeroCartao, int codigoSeguranca, string banco, string dataPagamento)
        {
            IdPagamento = idPagamento;
            Descricao = descricao;
            NomeUsuario = nomeUsuario;
            CPF = cPF;
            NumeroCartao = numeroCartao;
            CodigoSeguranca = codigoSeguranca;
            Banco = banco;
            DataPagamento = dataPagamento;
        }


    }
}
