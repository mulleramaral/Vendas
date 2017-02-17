using Vendas.Application.Interface;
using Vendas.Domain.Entities;

namespace Vendas.MVC.Controllers
{
    public class AdiantamentoClienteController : AdiantamentoController<AdiantamentoCliente>
    {
        public AdiantamentoClienteController(IServicoDeAplicacaoDeAdiantamento<AdiantamentoCliente> servicoDeAplicacao) : base(servicoDeAplicacao)
        {
        }
    }
}