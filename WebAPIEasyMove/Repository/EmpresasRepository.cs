using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPIEasyMove.Models;
using WebAPIEasyMove.Repository.Context;

namespace WebAPIEasyMove.Repository
{
    public class EmpresasRepository
    {
        private readonly DataBaseContext context;

        public EmpresasRepository()
        {
            context = new DataBaseContext();
        }

        public IList<Empresas> Listar()
        {
            return context.Empresas.ToList();
        }

        public void Inserir(Empresas empresas)
        {
            context.Empresas.Add(empresas);
            context.SaveChanges();
        }

        public Empresas Consultar(int id)
        {
            return context.Empresas.Find(id);
        }

        public void Alterar(Empresas empresas)
        {
            context.Empresas.Update(empresas);
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            var empresas = new Empresas
            {
                IdEmpresa = id
            };

            context.Empresas.Remove(empresas);
            context.SaveChanges();
        }
    }
}
