using Microsoft.AspNetCore.Mvc;
using SisRh.WEB.Models.Util.Components;

namespace SisRh.WEB.ViewComponents
{
    public class BotaoDefaultViewComponent : ViewComponent
    {
        public BotaoDefaultViewComponent()
        {

        }

        public IViewComponentResult Invoke(BotaoDefault.TiposTela tipoTela, string controllerName)
        {
            return View(new BotaoDefault()
            {
                TipoTela = tipoTela,
                ControllerName = controllerName
            });
        }
    }
}
