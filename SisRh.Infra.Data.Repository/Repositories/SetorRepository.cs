using Microsoft.EntityFrameworkCore;
using SisRh.Domain.Entities;
using SisRh.Domain.Interfaces.Repositories;
using SisRh.Infra.Data.Context;
using SisRh.Infra.Data.Repository.Repositories.Common;
using System.Collections.Generic;
using System.Linq;

namespace SisRh.Infra.Data.Repository.Repositories
{
    public class SetorRepository : RepositoryBase<Setor>, ISetorRepository
    {
        public SetorRepository(SisRhContext dt)
            :base(dt)
        {

        }

        public override IEnumerable<object> GetListToSelect()
        {
            return this._dt.Setores.ToList().Select(setor => new { Text = setor.Nome, Value = setor.Codigo }).OrderBy(x => x.Text);
        }

        public override IEnumerable<Setor> GetAll()
        {
            return _dt.Setores.AsNoTracking().OrderBy(x => x.Nome).ToList();
        }
    }
}
