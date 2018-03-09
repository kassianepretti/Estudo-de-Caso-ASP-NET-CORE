using Microsoft.AspNetCore.Mvc.ModelBinding;
using SisRh.Domain.Core.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SisRh.WEB.Models.Util
{
    public static class Funcoes
    {
        public static void MontaMensagemErro(ModelStateDictionary modelState, List<MensagemValidation> listaMensagemValidation)
        {
            foreach(var obj in listaMensagemValidation)
            {
                modelState.AddModelError(obj.Campo, obj.Mensagem);
            }
        }
    }
}
