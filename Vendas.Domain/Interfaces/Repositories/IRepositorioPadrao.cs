using System.Collections.Generic;

namespace Vendas.Domain.Interfaces.Repositories
{
    public interface IRepositorioPadrao<TEntity> where TEntity : class
    {
        void Inserir(TEntity obj);
        TEntity Obter(int id);
        IEnumerable<TEntity> Obter();
        void Alterar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
