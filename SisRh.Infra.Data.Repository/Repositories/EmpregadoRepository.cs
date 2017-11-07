using System.Collections.Generic;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Infra.Data.Context;
using SisRh.Infra.Data.Repository.Repositories.Common;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace SisRh.Infra.Data.Repository.Repositories
{
    public class EmpregadoRepository : RepositoryBase<Empregado>, IEmpregadoRepository
    {
        public EmpregadoRepository(SisRhContext dt)
            :base(dt)
        {

        }

        public override IEnumerable<Empregado> GetAll()
        {
            //return from e in _dt.Empregados.Include("Setor").AsNoTracking()
            //            where EF.Functions.Like(e.Nome, "K%")
            //            orderby e.Nome
            //            select e;
            
            return _dt.Empregados.Include(y => y.Setor).AsNoTracking().OrderBy(x => x.Nome).ToList();
        }
    }
}
