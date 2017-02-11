using System.Collections.Generic;
using System.Linq;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Repositories;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Domain.Services
{
    public class ServicoDeCliente : ServicoPadrao<Cliente>, IServicoDeCliente
    {
        private readonly IRepositorioDeCliente repositorioDeCliente;

        public ServicoDeCliente(IRepositorioDeCliente repositorioDeCliente) 
            : base(repositorioDeCliente)
        {
            this.repositorioDeCliente = repositorioDeCliente;
        }

        public IEnumerable<Cliente> ObterClienteEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(c => c.ClienteEspecial(c));
        }
    }
}
