using MovieApp.Web.Models;

namespace MovieApp.Web.Data
{
    public class MovieRepository
    {
        private static readonly List<Movie> _movies = null;

        static MovieRepository()
        {
            _movies= new List<Movie>()
            {
                new Movie{
                        MovieId=1,
                        Name="film 1",
                        Description= "açıklama 1",
                        Director="yönetmen 1",
                        Aktors= new string[]{"oyuncu 1", "oyuncu 2" },
                        ImageUrl="1.png",
                        GenreId=1 },
                new Movie{
                        MovieId=2,
                        Name="film 2",
                        Description= "açıklama 2",
                        Director="yönetmen 2",
                        Aktors=new string[]{"oyuncu 1", "oyuncu 2"},
                        ImageUrl="2.png",
                        GenreId=3 },
                new Movie{
                        MovieId = 3,
                        Name="film 3",
                        Description= "açıklama 3",
                        Director="yönetmen 3",
                        Aktors=new string[]{"oyuncu 1", "oyuncu 2" },
                        ImageUrl="3.png",
                        GenreId=4 }
            };
        }
        public static List<Movie> Movies
        {
            get
            {
                return _movies;
            }
        }


        public static void Add(Movie movie)
        {
            _movies.Add(movie);
        }

        public static Movie GetById(int id)
        {
            return _movies.FirstOrDefault(m => m.MovieId == id);
        }

    }
}
