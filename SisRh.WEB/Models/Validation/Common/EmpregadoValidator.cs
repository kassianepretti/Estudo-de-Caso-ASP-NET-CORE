using FluentValidation;
using SisRh.WEB.Models.ViewModels;

namespace SisRh.WEB.Models.Validation.Common
{
    public class EmpregadoValidator<T> : AbstractValidator<T> where T : EmpregadoViewModel
    {
        protected void ValidationNome()
        {
            RuleFor(empregado => empregado.Nome)
                .NotEmpty().WithMessage(Resources.MensagemResource.MSG_CAMPO_OBRIGATORIO)
                .Length(1, 256).WithMessage(Resources.MensagemResource.MSG_CAMPO_MAX_LEN);
        }

        protected void ValidationEmail()
        {
            RuleFor(empregado => empregado.Email)
                .NotEmpty().WithMessage(Resources.MensagemResource.MSG_CAMPO_OBRIGATORIO)
                .Length(1, 100).WithMessage(Resources.MensagemResource.MSG_CAMPO_MAX_LEN)
                .EmailAddress().WithMessage(Resources.MensagemResource.MSG_CAMPO_INVALIDO);
        }

        protected void ValidationTelCelular()
        {
            RuleFor(empregado => empregado.TelCelular)
                .NotEmpty().When(empregado => string.IsNullOrEmpty(empregado.TelResidencial)).WithMessage(Resources.MensagemResource.MSG_INFORME_TELEFONE)
                .Length(1, 20).WithMessage(Resources.MensagemResource.MSG_CAMPO_MAX_LEN);
        }

        protected void ValidationTelResidencial()
        {
            RuleFor(empregado => empregado.TelResidencial)
                .NotEmpty().When(empregado => string.IsNullOrEmpty(empregado.TelCelular)).WithMessage(Resources.MensagemResource.MSG_INFORME_TELEFONE)
                .Length(1, 20).WithMessage(Resources.MensagemResource.MSG_CAMPO_MAX_LEN);
        }

        protected void ValidationDataNasc()
        {
            RuleFor(empregado => empregado.DataNasc)
                .NotEmpty().WithMessage(Resources.MensagemResource.MSG_CAMPO_OBRIGATORIO);
        }

        protected void ValidationCodSetor()
        {
            RuleFor(empregado => empregado.CodSetor)
                .NotEmpty().WithMessage(Resources.MensagemResource.MSG_CAMPO_OBRIGATORIO);
        }
    }
}
