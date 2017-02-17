using System.Data.Entity.ModelConfiguration;
using Vendas.Domain.Entities;

namespace Vendas.Infra.Data.EntityConfig
{
    public abstract class AdiantamentoConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : Adiantamento
    {
        public AdiantamentoConfiguration()
        {
            HasKey(p => p.Id);

            Property(p => p.Pessoa)
                .IsRequired();

            Property(p => p.Valor)
                .IsRequired()
                .HasPrecision(15, 2);
        }
    }
}
