using Microsoft.EntityFrameworkCore;
using SisRh.Domain.Entities;

namespace SisRh.Infra.Data.Context.Configurations
{
    public static class EmpregadoBeneficioContext
    {
        public static void EmpregadoBeneficioConfiguration(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmpregadoBeneficio>(ep =>
            {
                ep.ToTable("EmpregadoBeneficio");
                ep.HasKey(prop => new { prop.CodEmpregado, prop.CodBeneficio });
            });

            modelBuilder.Entity<EmpregadoBeneficio>()
                .HasOne(empregado => empregado.Empregado)
                .WithMany(empregado => empregado.EmpregadoBeneficios)
                .HasForeignKey(eb => eb.CodEmpregado)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();

            modelBuilder.Entity<EmpregadoBeneficio>()
                .HasOne(beneficio => beneficio.Beneficio)
                .WithMany(beneficio => beneficio.EmpregadoBeneficios)
                .HasForeignKey(eb => eb.CodBeneficio)
                .OnDelete(DeleteBehavior.Restrict)
                .IsRequired();
        }
    }
}
