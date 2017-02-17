using Vendas.Domain.Entities;

namespace Vendas.Application.Interface
{
    public interface IServicoDeAplicacaoDeAdiantamento<TEntity> : IServicoDeAplicacaoPadrao<TEntity> where TEntity : Adiantamento
    {
        string ObterNomeServico();
        string ObterNomeRepositorio();
    }
}
