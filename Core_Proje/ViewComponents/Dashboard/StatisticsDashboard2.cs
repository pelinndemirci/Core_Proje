using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.value1 = c.Portfolios.Count();
            ViewBag.value2 = c.Messages.Count();
            ViewBag.value3 = c.Services.Count();
               return View();
        }
    }
}
