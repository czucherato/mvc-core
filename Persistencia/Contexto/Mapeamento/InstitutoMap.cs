using CoreMvc.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CoreMvc.Persistencia.Contexto.Mapeamento
{
    public class InstitutoMap : IEntityTypeConfiguration<Instituto>
    {
        public void Configure(EntityTypeBuilder<Instituto> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).IsRequired();
        }
    }
}