using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MovieList.Models;

namespace MovieList.Controllers
{
    public class HomeController : Controller
    {
        private MovieContext context { get; set; }
        public HomeController(MovieContext ctx)
        {
            context = ctx;
        }
        public ViewResult Index(string activeGenre = "all")
        {

            ViewBag.ActiveGenre = activeGenre;

            List<Genre> genres = context.Genres.ToList();
            genres.Insert(0, new Genre { GenreId = "all", Name = "All" });

            ViewBag.Genre = genres;

            IQueryable<Movie> query = context.Movies;
            if (activeGenre != "all")
                query = query.Where(
                    t => t.Genre.GenreId.ToLower() ==
                        activeGenre.ToLower());
            var genre= query.ToList();
            return View(genres);
        }
    }
}