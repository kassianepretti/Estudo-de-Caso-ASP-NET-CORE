using SisRh.Domain.Core.Entities;
using System;
using System.Collections.Generic;

namespace SisRh.Domain.Entities
{
    public class Empregado : Entity
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string TelResidencial { get; set; }
        public string TelCelular { get; set; }
        public DateTime DataNasc { get; set; }
        public int CodSetor { get; set; }

        public virtual Setor Setor { get; set; }
        public virtual ICollection<EmpregadoBeneficio> EmpregadoBeneficios { get; set; }

        /// <summary>
        /// Verificar se o cpf do empregado é único
        /// </summary>
        /// <param name="empregado">Objeto empregado para comparação</param>
        /// <returns>TRUE - CPF é único; FALSE - CPF não é único</returns>
        public bool VerificaCpfUnico(Empregado empregado)
        {
            return !(this.Codigo != empregado.Codigo && this.Cpf == empregado.Cpf);
        }
    }
}
