using System.Collections.Generic;

namespace Vendas.Application.Interface
{
    public interface IServicoDeAplicacaoPadrao<TEntity> where TEntity : class
    {
        void Inserir(TEntity obj);
        TEntity Obter(int id);
        IEnumerable<TEntity> Obter();
        void Alterar(TEntity obj);
        void Remover(TEntity obj);
        void Dispose();
    }
}
