using Microsoft.AspNetCore.Mvc;
using MovieApp.Web.Data;
using MovieApp.Web.Models;

namespace MovieApp.Web.Controllers
{
    public class MoviesController : Controller
    {
        //public IActionResult List()
        // {
        //     return View();
        // }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult List()
        {
            
            //var genreOfFilms = new List<Genre>()
            //{
            //    new Genre{Name="Macera"},
            //    new Genre{Name="Aşk"},
            //    new Genre{Name="Komedi"},
            //    new Genre{Name="Savaş"}

            //};

            var model = new MoviesViewModel()
            {
                Movies = MovieRepository.Movies
                //Genres = genreOfFilms
            };

            return View("Movies", model);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
