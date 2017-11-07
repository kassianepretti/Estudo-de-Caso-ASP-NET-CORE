using Microsoft.EntityFrameworkCore;
using SisRh.Domain.Entities;
using SisRh.Infra.Data.Context.Configurations;

namespace SisRh.Infra.Data.Context
{
    public class SisRhContext : DbContext
    {
        public DbSet<Empregado> Empregados { get; set; }
        public DbSet<Setor> Setores { get; set; }
        public DbSet<Beneficio> Beneficios { get; set; }
        public DbSet<EmpregadoBeneficio> EmpregadoBeneficios { get; set; }

        public SisRhContext(DbContextOptions<SisRhContext> options)
            : base(options)
        {

        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ForSqlServerUseIdentityColumns();

            //Model-level query filters
            //modelBuilder.Entity<Empregado>().HasQueryFilter(
            //x => x.TelCelular != null);
            
            GeralContext.GeralConfiguration(modelBuilder);
        }
    }
}
