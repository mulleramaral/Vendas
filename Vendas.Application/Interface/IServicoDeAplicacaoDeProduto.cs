using System.Collections.Generic;
using Vendas.Domain.Entities;

namespace Vendas.Application.Interface
{
    public interface IServicoDeAplicacaoDeProduto: IServicoDeAplicacaoPadrao<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
