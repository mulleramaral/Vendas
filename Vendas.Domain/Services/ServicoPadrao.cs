using System;
using System.Collections.Generic;
using Vendas.Domain.Interfaces.Repositories;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Domain.Services
{
    public class ServicoPadrao<TEntity> : IDisposable, IServicoPadrao<TEntity> where TEntity : class
    {
        private readonly IRepositorioPadrao<TEntity> repositorioPadrao;

        public ServicoPadrao(IRepositorioPadrao<TEntity> repositorioPadrao)
        {
            this.repositorioPadrao = repositorioPadrao;
        }

        public void Inserir(TEntity obj)
        {
            repositorioPadrao.Inserir(obj);
        }

        public void Alterar(TEntity obj)
        {
            repositorioPadrao.Alterar(obj);
        }

        public IEnumerable<TEntity> Obter()
        {
            return repositorioPadrao.Obter();
        }

        public TEntity Obter(int id)
        {
            return repositorioPadrao.Obter(id);
        }

        public void Remover(TEntity obj)
        {
            repositorioPadrao.Remover(obj);
        }

        public void Dispose()
        {
            repositorioPadrao.Dispose();
        }
    }
}
