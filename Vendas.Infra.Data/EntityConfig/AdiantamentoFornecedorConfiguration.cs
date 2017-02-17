using Vendas.Domain.Entities;

namespace Vendas.Infra.Data.EntityConfig
{
    public class AdiantamentoFornecedorConfiguration : AdiantamentoConfiguration<AdiantamentoFornecedor>
    {
        public AdiantamentoFornecedorConfiguration()
        {
            ToTable("adiantamentofornecedor");
        }
    }
}
