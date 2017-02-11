using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Vendas.Application.Interface;
using Vendas.Domain.Entities;
using Vendas.MVC.ViewModels;

namespace Vendas.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IServicoDeAplicacaoDeProduto servicoDeAplicacaoDeProduto;
        private readonly IServicoDeAplicacaoDeCliente servicoDeAplicacaoDeCliente;

        public ProdutoController(
            IServicoDeAplicacaoDeProduto _servicoDeAplicacaoDeProduto,
            IServicoDeAplicacaoDeCliente _servicoDeAplicacaoDeCliente
            )
        {
            servicoDeAplicacaoDeProduto = _servicoDeAplicacaoDeProduto;
            servicoDeAplicacaoDeCliente = _servicoDeAplicacaoDeCliente;
        }

        public ActionResult Index()
        {
            var produtosViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(servicoDeAplicacaoDeProduto.Obter());
            return View(produtosViewModel);
        }

        public ActionResult Details(int id)
        {
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(servicoDeAplicacaoDeProduto.Obter(id));
            return View(produtoViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.ClienteId = new SelectList(servicoDeAplicacaoDeCliente.Obter(), "ClienteId","Nome");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDominio = Mapper.Map<ProdutoViewModel, Produto>(produto);
                servicoDeAplicacaoDeProduto.Inserir(produtoDominio);

                return RedirectToAction("Index");
            }

            ViewBag.ClienteId = new SelectList(servicoDeAplicacaoDeCliente.Obter(), "ClienteId", "Nome",produto.ClienteId);
            return View(produto);
        }

        public ActionResult Edit(int id)
        {
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(servicoDeAplicacaoDeProduto.Obter(id));

            ViewBag.ClienteId = new SelectList(servicoDeAplicacaoDeCliente.Obter(), "ClienteId", "Nome",produtoViewModel.ClienteId);
            return View(produtoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDominio = Mapper.Map<ProdutoViewModel, Produto>(produto);
                servicoDeAplicacaoDeProduto.Alterar(produtoDominio);

                return RedirectToAction("Index");
            }

            return View(produto);
        }

        public ActionResult Delete(int id)
        {
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(servicoDeAplicacaoDeProduto.Obter(id));
            return View(produtoViewModel);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            servicoDeAplicacaoDeProduto.Remover(servicoDeAplicacaoDeProduto.Obter(id));
            return RedirectToAction("Index");
        }
    }
}