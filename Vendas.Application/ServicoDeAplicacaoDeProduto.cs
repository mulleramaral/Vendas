using System.Collections.Generic;
using Vendas.Application.Interface;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Application
{
    public class ServicoDeAplicacaoDeProduto : ServicoDeAplicacaoPadrao<Produto> , IServicoDeAplicacaoDeProduto
    {
        private readonly IServicoDeProduto servicoDeProduto;

        public ServicoDeAplicacaoDeProduto(IServicoDeProduto servicoDeProduto)
            : base(servicoDeProduto)
        {
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return servicoDeProduto.BuscarPorNome(nome);
        }
    }
}
