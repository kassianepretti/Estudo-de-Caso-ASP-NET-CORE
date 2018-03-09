using SisRh.Domain.Core.Service;
using SisRh.Domain.Core.Util;
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
        
        public void ValidarObjeto(Empregado empregado)
        {
            if (_repository.ExisteCpf(empregado))
               this.AddMensagem("Cpf", "Cpf já existe.");
            
        }
    }
}
