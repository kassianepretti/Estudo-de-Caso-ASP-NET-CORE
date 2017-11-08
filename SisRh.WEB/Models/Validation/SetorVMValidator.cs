using SisRh.WEB.Models.Validation.Common;
using SisRh.WEB.Models.ViewModels;

namespace SisRh.WEB.Models.Validation
{
    public class SetorVMValidator : SetorValidator<SetorViewModel>
    {
        public SetorVMValidator()
        {
            ValidationNome();
            ValidationSigla();            
        }
    }
}
