using Microsoft.EntityFrameworkCore;
using SisRh.Domain.Entities;

namespace SisRh.Infra.Data.Context.Configurations
{
    public static class SetorContext
    {
        public static void SetorConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setor>(setor =>
            {
                setor.ToTable("Setor");
                setor.HasKey(prop => prop.Codigo);
                setor.Property(prop => prop.Codigo).ValueGeneratedOnAdd();
                setor.Property(prop => prop.Nome).IsRequired().HasMaxLength(256);
                setor.Property(prop => prop.Sigla).IsRequired().HasMaxLength(5);
            });
        }
    }
}
