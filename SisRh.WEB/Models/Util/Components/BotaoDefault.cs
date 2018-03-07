namespace SisRh.WEB.Models.Util.Components
{
    public class BotaoDefault
    {
        public enum TiposTela { Criar, Editar, Listar, Deletar, Detalhar };

        public TiposTela TipoTela { get; set; }
        public string ControllerName { get; set; }
    }
}
