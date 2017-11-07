using SisRh.Domain.Base.Service;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Domain.Interfaces.Services;

namespace SisRh.Domain.Services
{
    public class EmpregadoService : ServiceBase<Empregado>, IEmpregadoService
    {
        private readonly IEmpregadoRepository _repository;

        public EmpregadoService(IEmpregadoRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
