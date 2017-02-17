using System.Web.Mvc;
using Vendas.Application.Interface;
using Vendas.Domain.Entities;

namespace Vendas.MVC.Controllers
{
    public class AdiantamentoController<TEntity> : Controller where TEntity : Adiantamento
    {
        readonly IServicoDeAplicacaoDeAdiantamento<TEntity> servicoDeAplicacao;

        public AdiantamentoController(IServicoDeAplicacaoDeAdiantamento<TEntity> servicoDeAplicacao)
        {
            this.servicoDeAplicacao = servicoDeAplicacao;
        }

        public ActionResult Index()
        {
            return Content(servicoDeAplicacao.ToString());
        }

        public ActionResult servico()
        {
            return Content(servicoDeAplicacao.ObterNomeServico());
        }

        public ActionResult repositorio()
        {
            return Content(servicoDeAplicacao.ObterNomeRepositorio());
        }
    }
}