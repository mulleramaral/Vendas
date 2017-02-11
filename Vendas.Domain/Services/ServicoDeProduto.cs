using System;
using System.Collections.Generic;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Repositories;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Domain.Services
{
    public class ServicoDeProduto : ServicoPadrao<Produto>,IServicoDeProduto
    {
        private readonly IRepositorioDeProduto repositorioDeProduto;

        public ServicoDeProduto(IRepositorioDeProduto repositorioDeProduto)
            : base(repositorioDeProduto)
        {
            this.repositorioDeProduto = repositorioDeProduto;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return repositorioDeProduto.BuscarPorNome(nome);
        }
    }
}
