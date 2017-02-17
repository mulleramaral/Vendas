using Vendas.Domain.Entities;

namespace Vendas.Domain.Interfaces.Repositories
{
    public interface IRepositorioDeAdiantamento<TEntity> : IRepositorioPadrao<TEntity> where TEntity : Adiantamento
    {
    }
}
