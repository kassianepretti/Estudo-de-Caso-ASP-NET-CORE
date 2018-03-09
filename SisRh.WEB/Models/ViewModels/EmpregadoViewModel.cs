using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.ComponentModel.DataAnnotations;

namespace SisRh.WEB.Models.ViewModels
{
    public class EmpregadoViewModel
    {
        [Key]
        [Display(ResourceType = typeof(Resources.LabelResource),  Name = "LBL_CODIGO")]
        public int Codigo { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_NOME")]
        public string Nome { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_EMAIL")]
        public string Email { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_CPF")]
        public string Cpf { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_TEL_RESIDENCIAL")]
        public string TelResidencial { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_TEL_CELULAR")]
        public string TelCelular { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_DATA_NASC")]
        public DateTime? DataNasc { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_SETOR")]
        public int CodSetor { get; set; }

        public virtual SetorViewModel Setor { get; set; }

        public SelectList ListaSetores { get; set; }
    }
}
