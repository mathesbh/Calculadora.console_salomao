using Application.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data
{
    public class OperacoesHistoricoMapping : IEntityTypeConfiguration<OperacoesHistorico>
    {
        public void Configure(EntityTypeBuilder<OperacoesHistorico> builder)
        {
            builder.HasKey(e => e.Id);
        }
    }
}
