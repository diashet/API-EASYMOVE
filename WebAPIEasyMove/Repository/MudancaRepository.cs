using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEasyMove.Models;
using WebAPIEasyMove.Repository.Context;

namespace WebAPIEasyMove.Repository
{
    public class MudancaRepository
    {

        private readonly DataBaseContext context;

        public MudancaRepository()
        {
            context = new DataBaseContext();
        }

        public IList<Mudanca> Listar()
        {
            return context.Mudanca.ToList();
        }

        public void Inserir(Mudanca mudanca)
        {
            context.Mudanca.Add(mudanca);
            context.SaveChanges();
        }

        public Mudanca Consultar(int id)
        {
            return context.Mudanca.Find(id);
        }

        public void Alterar(Mudanca mudanca)
        {
            context.Mudanca.Update(mudanca);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var mudanca = new Mudanca
            {
                IdMudanca = id
            };

            context.Mudanca.Remove(mudanca);
            context.SaveChanges();
        }
    }
}
