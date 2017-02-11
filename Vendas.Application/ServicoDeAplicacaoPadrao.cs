using System.Collections.Generic;
using Vendas.Application.Interface;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Application
{
    public class ServicoDeAplicacaoPadrao<TEntity> : IServicoDeAplicacaoPadrao<TEntity> where TEntity : class
    {
        readonly IServicoPadrao<TEntity> servicoPadrao;

        public ServicoDeAplicacaoPadrao(IServicoPadrao<TEntity> servicoPadrao)
        {
            this.servicoPadrao = servicoPadrao;
        }

        public void Inserir(TEntity obj)
        {
            servicoPadrao.Inserir(obj);
        }

        public void Alterar(TEntity obj)
        {
            servicoPadrao.Alterar(obj);
        }

        public IEnumerable<TEntity> Obter()
        {
            return servicoPadrao.Obter();
        }

        public TEntity Obter(int id)
        {
            return servicoPadrao.Obter(id);
        }

        public void Remover(TEntity obj)
        {
            servicoPadrao.Remover(obj);
        }

        public void Dispose()
        {
        }
    }
}
