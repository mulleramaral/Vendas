using Vendas.Domain.Entities;

namespace Vendas.Infra.Data.EntityConfig
{
    public class AdiantamentoClienteConfiguration : AdiantamentoConfiguration<AdiantamentoCliente>
    {
        public AdiantamentoClienteConfiguration()
        {
            ToTable("adiantamentocliente");
        }
    }
}
