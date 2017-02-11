using AutoMapper;
using System.Collections.Generic;
using System.Web.Mvc;
using Vendas.Application.Interface;
using Vendas.Domain.Entities;
using Vendas.MVC.ViewModels;

namespace Vendas.MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IServicoDeAplicacaoDeCliente servicoDeAplicacaoDeCliente;

        public ClienteController(IServicoDeAplicacaoDeCliente servicoDeAplicacaoDeCliente)
        {
            this.servicoDeAplicacaoDeCliente = servicoDeAplicacaoDeCliente;
        }

        public ActionResult Index()
        {
            var clienteViewModel = Mapper.Map<IEnumerable<Cliente>,IEnumerable<ClienteViewModel>>(servicoDeAplicacaoDeCliente.Obter());
            return View(clienteViewModel);
        }

        public ActionResult Details(int id)
        {
            var cliente = servicoDeAplicacaoDeCliente.Obter(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                servicoDeAplicacaoDeCliente.Inserir(cliente);

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }

        public ActionResult Edit(int id)
        {
            var cliente = servicoDeAplicacaoDeCliente.Obter(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ClienteViewModel clienteViewModel)
        {
            if (ModelState.IsValid)
            {
                var cliente = Mapper.Map<ClienteViewModel, Cliente>(clienteViewModel);
                servicoDeAplicacaoDeCliente.Alterar(cliente);

                return RedirectToAction("Index");
            }

            return View(clienteViewModel);
        }

        public ActionResult Delete(int id)
        {
            var cliente = servicoDeAplicacaoDeCliente.Obter(id);
            var clienteViewModel = Mapper.Map<Cliente, ClienteViewModel>(cliente);

            return View(clienteViewModel);
        }

        [HttpPost,ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var cliente = servicoDeAplicacaoDeCliente.Obter(id);
            servicoDeAplicacaoDeCliente.Remover(cliente);

            return RedirectToAction("Index");
        }

        public ActionResult Especiais()
        {
            var clientes = servicoDeAplicacaoDeCliente.ObterClientesEspeciais();
            var clientesViewModel = Mapper.Map<IEnumerable<Cliente>, IEnumerable<ClienteViewModel>>(clientes);

            return View(clientesViewModel);
        }
    }
}