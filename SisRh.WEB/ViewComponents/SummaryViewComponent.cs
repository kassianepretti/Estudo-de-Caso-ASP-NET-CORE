using Microsoft.AspNetCore.Mvc;

namespace SisRh.WEB.ViewComponents
{
    public class SummaryViewComponent : ViewComponent
    {
        public SummaryViewComponent()
        {

        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
