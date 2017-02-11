using AutoMapper;
using Vendas.Domain.Entities;
using Vendas.MVC.ViewModels;

namespace Vendas.MVC.AutoMapper
{
    public class DominioParaViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DominioParaViewModelMappings"; }
        }

        public DominioParaViewModelMappingProfile()
        {
            CreateMap<Cliente, ClienteViewModel>();
            CreateMap<Produto, ProdutoViewModel>();
        }
    }
}