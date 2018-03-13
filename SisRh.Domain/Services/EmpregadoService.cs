using SisRh.Domain.Core.Service;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Domain.Interfaces.Services;

namespace SisRh.Domain.Services
{
    public class EmpregadoService : ServiceBase<Empregado>, IEmpregadoService
    {
        private readonly IEmpregadoRepository _repository;

        public EmpregadoService(IEmpregadoRepository repository)
            : base(repository)
        {
            _repository = repository;
        }

        public override void Add(Empregado obj)
        {
            if (_repository.ExisteCpf(obj))
                this.AddMensagem("Cpf", Properties.Resources.MSG_CPF_JA_EXISTE);

            if (OperacaoValida())
                base.Add(obj);
        }

        public override void Update(Empregado obj)
        {
            if (_repository.ExisteCpf(obj))
                this.AddMensagem("Cpf", Properties.Resources.MSG_CPF_JA_EXISTE);

            if (OperacaoValida())
                base.Update(obj);
        }

    }
}
