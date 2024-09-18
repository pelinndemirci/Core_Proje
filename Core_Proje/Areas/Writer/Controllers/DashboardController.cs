using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.value = values.Name + " " + values.Surname;

            //Hava Durumu İçin Api Kullanım Örneği
            //WeatherApi
            //string api = "api_key";
            //string connection = "url_gir" + api;
            //XDocument document = XDocument.Load(connection);
            //ViewBag.value5 = document.Descendants("tempature").ElementAt(0).Attributes("value").Value;


            //statistics

            Context c = new Context();
            ViewBag.value1 = c.writerMessages.Where(x=>x.Receiver==values.Email).Count();
            ViewBag.value2 = c.announcements.Count();
            ViewBag.value3 = c.Users.Count();
            ViewBag.value4 = c.Skills.Count();
            return View();
        }
    }
}
