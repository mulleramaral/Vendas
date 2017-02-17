using Vendas.Application.Interface;
using Vendas.Domain.Entities;

namespace Vendas.MVC.Controllers
{
    public class AdiantamentoFornecedorController : AdiantamentoController<AdiantamentoFornecedor>
    {
        public AdiantamentoFornecedorController(IServicoDeAplicacaoDeAdiantamento<AdiantamentoFornecedor> servicoDeAplicacao) : base(servicoDeAplicacao)
        {
        }
    }
}