using System;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Repositories;
using Vendas.Domain.Interfaces.Services;

namespace Vendas.Domain.Services
{
    public class ServicoDeAdiantamento<TEntity> : ServicoPadrao<TEntity>,IServicoDeAdiantamento<TEntity> where TEntity : Adiantamento
    {
        IRepositorioDeAdiantamento<TEntity> repositorio;

        public ServicoDeAdiantamento(IRepositorioDeAdiantamento<TEntity> _repositorio) : base(_repositorio)
        {
            repositorio = _repositorio;
        }

        public string ObterNomeRepositorio()
        {
            return repositorio.ToString();
        }
    }
}
