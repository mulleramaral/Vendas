using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Repositories;

namespace Vendas.Domain.Interfaces.Services
{
    public interface  IServicoDeAdiantamento<TEntity> : IServicoPadrao<TEntity> where TEntity : Adiantamento
    {
        string ObterNomeRepositorio();
    }
}
