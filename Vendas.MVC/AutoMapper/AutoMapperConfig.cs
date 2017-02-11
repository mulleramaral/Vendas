using AutoMapper;

namespace Vendas.MVC.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMappings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.AddProfile(new DominioParaViewModelMappingProfile());
                cfg.AddProfile(new ViewModelParaDominioMappingProfile());
            });
        }
    }
}