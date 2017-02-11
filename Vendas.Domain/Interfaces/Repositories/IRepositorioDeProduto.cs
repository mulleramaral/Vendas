using System.Collections.Generic;
using Vendas.Domain.Entities;

namespace Vendas.Domain.Interfaces.Repositories
{
    public interface IRepositorioDeProduto : IRepositorioPadrao<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
