using AutoMapper;
using Vendas.Domain.Entities;
using Vendas.MVC.ViewModels;

namespace Vendas.MVC.AutoMapper
{
    public class ViewModelParaDominioMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelParaDominio"; }
        }

        public ViewModelParaDominioMappingProfile()
        {
            CreateMap<ClienteViewModel, Cliente>();
            CreateMap<ProdutoViewModel, Produto>();
        }
    }
}