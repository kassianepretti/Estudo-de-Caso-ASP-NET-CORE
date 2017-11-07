using Microsoft.EntityFrameworkCore;
using SisRh.Domain.Entities;

namespace SisRh.Infra.Data.Context.Configurations
{
    public static class BeneficioContext
    {
        public static void BeneficioConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Beneficio>(setor =>
            {
                setor.ToTable("Beneficio");
                setor.HasKey(prop => prop.Codigo);
                setor.Property(prop => prop.Codigo).ValueGeneratedOnAdd();
                setor.Property(prop => prop.Nome).IsRequired().HasMaxLength(256);
                setor.Property(prop => prop.Descricao).IsRequired().HasMaxLength(1000);
            });
        }
    }
}
