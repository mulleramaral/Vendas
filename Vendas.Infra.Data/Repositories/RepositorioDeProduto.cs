using System.Collections.Generic;
using System.Linq;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Repositories;

namespace Vendas.Infra.Data.Repositories
{
    public class RepositorioDeProduto : RepositorioPadrao<Produto>, IRepositorioDeProduto
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return Db.Produtos.Where(p => p.Nome == nome);
        }
    }
}
