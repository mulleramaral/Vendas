using System.Collections.Generic;
using Vendas.Domain.Entities;

namespace Vendas.Domain.Interfaces.Services
{
    public interface IServicoDeCliente : IServicoPadrao<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes);
    }
}
