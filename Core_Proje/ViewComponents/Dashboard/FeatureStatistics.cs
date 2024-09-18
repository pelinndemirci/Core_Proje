using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.value1 = c.Skills.Count();
            ViewBag.value2 = c.Messages.Where(x=>x.Status == false).Count();
            ViewBag.value3 = c.Messages.Where(x=>x.Status == true).Count();
            ViewBag.value4 = c.Experiences.Count();
            return View();
        }
    }
}
