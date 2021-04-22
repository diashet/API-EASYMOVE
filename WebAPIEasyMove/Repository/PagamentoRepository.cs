using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEasyMove.Models;
using WebAPIEasyMove.Repository.Context;

namespace WebAPIEasyMove.Repository
{
    public class PagamentoRepository 
    {

        private readonly DataBaseContext context;

        public PagamentoRepository()
        {
            context = new DataBaseContext();
        }

        public IList<Pagamento> Listar()
        {
            return context.Pagamento.ToList();
        }

        public void Inserir(Pagamento pagamento)
        {
            context.Pagamento.Add(pagamento);
            context.SaveChanges();
        }

        public Pagamento Consultar(int id)
        {
            return context.Pagamento.Find(id);
        }

        public void Alterar(Pagamento pagamento)
        {
            context.Pagamento.Update(pagamento);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var pagamento = new Pagamento
            {
                IdPagamento = id
            };

            context.Pagamento.Remove(pagamento);
            context.SaveChanges();
        }

    }
}
