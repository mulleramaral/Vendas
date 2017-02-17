using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using System.Web.Mvc;
using Vendas.Application;
using Vendas.Application.Interface;
using Vendas.Domain.Entities;
using Vendas.Domain.Interfaces.Repositories;
using Vendas.Domain.Interfaces.Services;
using Vendas.Domain.Services;
using Vendas.Infra.Data.Repositories;

namespace Vendas.MVC.App_Start
{
    public class SimpleInjectorConfig
    {
        public static void RegisterInjector()
        {
            Container c = new Container();

            c.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            c.Register(typeof(IServicoDeAplicacaoPadrao<>), typeof(ServicoDeAplicacaoPadrao<>));
            c.Register(typeof(IServicoPadrao<>), typeof(ServicoPadrao<>));
            c.Register(typeof(IRepositorioPadrao<>), typeof(RepositorioPadrao<>));

            c.Register<IServicoDeAplicacaoDeCliente, ServicoDeAplicacaoDeCliente>();
            c.Register<IServicoDeAplicacaoDeProduto, ServicoDeAplicacaoDeProduto>();
            c.Register<IServicoDeCliente, ServicoDeCliente>(Lifestyle.Scoped);
            c.Register<IServicoDeProduto, ServicoDeProduto>(Lifestyle.Scoped);
            c.Register<IRepositorioDeCliente, RepositorioDeCliente>(Lifestyle.Scoped);
            c.Register<IRepositorioDeProduto, RepositorioDeProduto>(Lifestyle.Scoped);


            //Funcionou
            c.Register<IServicoDeAplicacaoDeAdiantamento<AdiantamentoCliente>, ServicoDeAplicacaoDeAdiantamento<AdiantamentoCliente>>(Lifestyle.Scoped);
            c.Register<IServicoDeAplicacaoDeAdiantamento<AdiantamentoFornecedor>, ServicoDeAplicacaoDeAdiantamento<AdiantamentoFornecedor>>(Lifestyle.Scoped);
            c.Register<IServicoDeAdiantamento<AdiantamentoFornecedor>, ServicoDeAdiantamento<AdiantamentoFornecedor>>(Lifestyle.Scoped);
            c.Register<IServicoDeAdiantamento<AdiantamentoCliente>, ServicoDeAdiantamento<AdiantamentoCliente>>(Lifestyle.Scoped);
            c.Register<IRepositorioDeAdiantamento<AdiantamentoCliente>, RepositorioDeAdiantamento<AdiantamentoCliente>>(Lifestyle.Scoped);
            c.Register<IRepositorioDeAdiantamento<AdiantamentoFornecedor>, RepositorioDeAdiantamento<AdiantamentoFornecedor>>(Lifestyle.Scoped);

            //Normal
            //c.Register<IRepositorioDeAdiantamentoCliente, RepositorioDeAdiantamentoCliente>(Lifestyle.Scoped);
            //c.Register<IRepositorioDeAdiantamentoFornecedor, RepositorioDeAdiantamentoFornecedor>(Lifestyle.Scoped);

            c.Verify();

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(c));
        }
    }
}