using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            string movieName = "film başlığı : ";
            string movieExplanation = "film açıklaması : ";
            string movieDirector = "filmin yönetmeni : ";
            string[] aktors = { "oyuncu 1 ", "oyuncu 2 " };

            Movie m = new Movie();

            m.Name = movieName;
            m.Description = movieExplanation;
            m.Aktors = aktors;


            return View(m);
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
