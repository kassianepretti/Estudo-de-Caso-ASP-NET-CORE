using SisRh.WEB.Models.Validation.Common;
using SisRh.WEB.Models.ViewModels;

namespace SisRh.WEB.Models.Validation
{
    public class EmpregadoVMValidator : EmpregadoValidator<EmpregadoViewModel>
    {
        public EmpregadoVMValidator()
        {
            ValidationNome();
            ValidationCpf();
            ValidationEmail();
            ValidationTelResidencial();
            ValidationTelCelular();
            ValidationDataNasc();
            ValidationCodSetor();
        }
    }
}
