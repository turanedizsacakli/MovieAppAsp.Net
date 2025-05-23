namespace MovieApp.Web.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string[] Aktors { get; set; }
        public string ImageUrl { get; set; }
        public int GenreId { get; set; }

    }
}
