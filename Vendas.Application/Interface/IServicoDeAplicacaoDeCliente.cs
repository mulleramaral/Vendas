using System.Collections.Generic;
using Vendas.Domain.Entities;

namespace Vendas.Application.Interface
{
    public interface IServicoDeAplicacaoDeCliente : IServicoDeAplicacaoPadrao<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
