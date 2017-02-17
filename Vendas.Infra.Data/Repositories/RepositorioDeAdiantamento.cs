using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Repositories;

namespace Vendas.Infra.Data.Repositories
{
    public class RepositorioDeAdiantamento<TEntity> : RepositorioPadrao<TEntity> , IRepositorioDeAdiantamento<TEntity> where TEntity : Adiantamento
    {
    }
}
