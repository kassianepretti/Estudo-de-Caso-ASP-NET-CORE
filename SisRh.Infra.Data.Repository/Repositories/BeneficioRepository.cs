using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Infra.Data.Context;
using SisRh.Infra.Data.Repository.Repositories.Common;

namespace SisRh.Infra.Data.Repository.Repositories
{
    public class BeneficioRepository : RepositoryBase<Beneficio>, IBeneficioRepository
    {
        public BeneficioRepository(SisRhContext dt)
            :base(dt)
        {

        }
    }
}
