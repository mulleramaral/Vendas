using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Vendas.Domain.Interfaces.Repositories;
using Vendas.Infra.Data.Contexto;

namespace Vendas.Infra.Data.Repositories
{
    public class RepositorioPadrao<TEntity> : IDisposable,IRepositorioPadrao<TEntity> where TEntity : class
    {
        protected VendasContext Db = new VendasContext();

        public void Inserir(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public void Alterar(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            Db.SaveChanges();
        }
      
        public IEnumerable<TEntity> Obter()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity Obter(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public void Remover(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
        }
    }
}
