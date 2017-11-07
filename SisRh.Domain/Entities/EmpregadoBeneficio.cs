namespace SisRh.Domain.Entities
{
    public class EmpregadoBeneficio
    {
        public int CodEmpregado { get; set; }
        public int CodBeneficio { get; set; }
        
        public virtual Empregado Empregado { get; set; }
        public virtual Beneficio Beneficio { get; set; }
    }
}
