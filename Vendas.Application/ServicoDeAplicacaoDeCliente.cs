using System;
using System.Collections.Generic;
using Vendas.Application.Interface;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Application
{
    public class ServicoDeAplicacaoDeCliente : ServicoDeAplicacaoPadrao<Cliente>, IServicoDeAplicacaoDeCliente
    {
        private readonly IServicoDeCliente servicoDeCliente;

        public ServicoDeAplicacaoDeCliente(IServicoDeCliente _servicoDeCliente)
            : base(_servicoDeCliente)
        {
            this.servicoDeCliente = _servicoDeCliente;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return servicoDeCliente.ObterClienteEspeciais(servicoDeCliente.Obter());
        }
    }
}
