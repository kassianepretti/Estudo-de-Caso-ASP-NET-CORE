using SisRh.Domain.Base.Entities;
using System.Collections.Generic;

namespace SisRh.Domain.Entities
{
    public class Beneficio : Entity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<EmpregadoBeneficio> EmpregadoBeneficios { get; set; }
    }
}
