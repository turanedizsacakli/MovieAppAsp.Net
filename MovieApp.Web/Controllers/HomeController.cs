using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new HomePageViewModel
            {
                PopularFilms = MovieRepository.Movies
            };


            return View(model);
        }

        public IActionResult About()
        {
            //var genreOfFilms = new List<Genre>()
            //{
            //    new Genre{Name="Macera"},
            //    new Genre{Name="Aşk"},
            //    new Genre{Name="Komedi"},
            //    new Genre{Name="Savaş"}

            //};
            //return View(genreOfFilms );

            return View();
        }
    }
}
