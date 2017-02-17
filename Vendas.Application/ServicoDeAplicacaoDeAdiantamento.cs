using System;
using Vendas.Application.Interface;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Application
{
    public class ServicoDeAplicacaoDeAdiantamento<TEntity> : ServicoDeAplicacaoPadrao<TEntity>, IServicoDeAplicacaoDeAdiantamento<TEntity> where TEntity : Adiantamento
    {
        readonly IServicoDeAdiantamento<TEntity> servico;

        public ServicoDeAplicacaoDeAdiantamento(IServicoDeAdiantamento<TEntity> _servico) : base(_servico)
        {
            servico = _servico;
        }

        public string ObterNomeServico()
        {
            return servico.ToString();
        }

        public string ObterNomeRepositorio()
        {
            return servico.ObterNomeRepositorio();
        }
    }
}
