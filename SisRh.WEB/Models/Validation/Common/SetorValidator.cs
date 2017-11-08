using FluentValidation;
using SisRh.WEB.Models.ViewModels;

namespace SisRh.WEB.Models.Validation.Common
{
    public class SetorValidator<T> : AbstractValidator<T> where T : SetorViewModel
    {
        protected void ValidationNome()
        {
            RuleFor(setor => setor.Nome)
                .NotEmpty().WithMessage(Resources.MensagemResource.MSG_CAMPO_OBRIGATORIO)
                .Length(1, 256).WithMessage(Resources.MensagemResource.MSG_CAMPO_MAX_LEN)
                .WithName(Resources.LabelResource.LBL_NOME);
        }

        protected void ValidationSigla()
        {
            RuleFor(setor => setor.Sigla)
                .NotEmpty().WithMessage(Resources.MensagemResource.MSG_CAMPO_OBRIGATORIO)
                .Length(1, 5).WithMessage(Resources.MensagemResource.MSG_CAMPO_MAX_LEN)
                .WithName(Resources.LabelResource.LBL_SIGLA);
        }
    }
}
