using SisRh.Domain.Core.Service;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Domain.Interfaces.Services;

namespace SisRh.Domain.Services
{
    public class BeneficioService : ServiceBase<Beneficio>, IBeneficioService
    {
        private readonly IBeneficioRepository _beneficioRepository;

        public BeneficioService(IBeneficioRepository beneficioRepository)
            :base(beneficioRepository)
        {
            _beneficioRepository = beneficioRepository;
        }
    }
}
