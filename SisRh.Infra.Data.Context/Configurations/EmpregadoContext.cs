using Microsoft.EntityFrameworkCore;
using SisRh.Domain.Entities;

namespace SisRh.Infra.Data.Context.Configurations
{
    public static class EmpregadoContext
    {
        public static void EmpregadoConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empregado>(empregado =>
            {
                empregado.ToTable("Empregado");
                empregado.HasKey(prop => prop.Codigo);
                empregado.Property(prop => prop.Codigo).ValueGeneratedOnAdd();
                empregado.Property(prop => prop.Nome).IsRequired().HasMaxLength(256);
                empregado.Property(prop => prop.Email).IsRequired().HasMaxLength(100);
                empregado.Property(prop => prop.Cpf).IsRequired(false).HasMaxLength(11);
                empregado.Property(prop => prop.TelResidencial).IsRequired().HasMaxLength(20);
                empregado.Property(prop => prop.TelCelular).IsRequired(false).HasMaxLength(20);
                empregado.Property(prop => prop.DataNasc).IsRequired();
            });

            modelBuilder.Entity<Empregado>()
                .HasOne(empregado => empregado.Setor)
                .WithMany(setor => setor.Empregados)
                .HasForeignKey(empregado => empregado.CodSetor)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
