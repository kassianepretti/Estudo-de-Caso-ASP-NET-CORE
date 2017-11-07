using System.ComponentModel.DataAnnotations;

namespace SisRh.WEB.Models.ViewModels
{
    public class SetorViewModel
    {
        [Key]
        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_CODIGO")]
        public int Codigo { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_NOME")]
        public string Nome { get; set; }

        [Display(ResourceType = typeof(Resources.LabelResource), Name = "LBL_SIGLA")]
        public string Sigla { get; set; }

    }
}
