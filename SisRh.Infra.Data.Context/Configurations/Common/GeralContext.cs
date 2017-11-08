using Microsoft.EntityFrameworkCore;

namespace SisRh.Infra.Data.Context.Configurations.Common
{
    public static class GeralContext
    {
        public static void GeralConfiguration(ModelBuilder modelBuilder)
        {
            EmpregadoContext.EmpregadoConfiguration(modelBuilder);
            SetorContext.SetorConfiguration(modelBuilder);
            BeneficioContext.BeneficioConfiguration(modelBuilder);
            EmpregadoBeneficioContext.EmpregadoBeneficioConfiguration(modelBuilder);
        }
    }
}
