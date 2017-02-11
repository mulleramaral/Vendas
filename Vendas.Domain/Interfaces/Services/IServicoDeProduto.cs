using System.Collections.Generic;
using Vendas.Domain.Entities;

namespace Vendas.Domain.Interfaces.Services
{
    public interface IServicoDeProduto : IServicoPadrao<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
