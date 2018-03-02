using SisRh.Domain.Core.Service;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Domain.Interfaces.Services;

namespace SisRh.Domain.Services
{
    public class SetorService : ServiceBase<Setor>, ISetorService
    {
        private readonly ISetorRepository _repository;

        public SetorService(ISetorRepository repository)
            :base(repository)
        {
            _repository = repository;
        }
    }
}
