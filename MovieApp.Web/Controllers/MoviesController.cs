using Microsoft.AspNetCore.Mvc;
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
            var filmList = new List<Movie>()
            {
                new Movie{ 
                        Name="film 1", 
                        Description= "açıklama 1", 
                        Director="yönetmen 1",
                        Aktors= new string[]{"oyuncu 1", "oyuncu 2" },                    
                        ImageUrl="1.png"},
                new Movie{ 
                        Name="film 2", 
                        Description= "açıklama 2", 
                        Director="yönetmen 2",
                        Aktors=new string[]{"oyuncu 1", "oyuncu 2"},
                        ImageUrl="2.png"
                            },
                new Movie{ 
                        Name="film 3", 
                        Description= "açıklama 3", 
                        Director="yönetmen 3",
                        Aktors=new string[]{"oyuncu 1", "oyuncu 2" },
                        ImageUrl="3.png"
                            }
            };

            return View("Movies", filmList);
        }
        public IActionResult Details()
        {
            return View();
        }
    }
}
