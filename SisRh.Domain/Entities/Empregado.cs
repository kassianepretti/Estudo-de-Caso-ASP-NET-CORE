using SisRh.Domain.Base.Entities;
using System;
using System.Collections.Generic;

namespace SisRh.Domain.Entities
{
    public class Empregado : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string TelResidencial { get; set; }
        public string TelCelular { get; set; }
        public DateTime DataNasc { get; set; }
        public int CodSetor { get; set; }

        public virtual Setor Setor { get; set; }
        public virtual ICollection<EmpregadoBeneficio> EmpregadoBeneficios { get; set; }
    }
}
