using System.ComponentModel.DataAnnotations;
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
            var genre = query.ToList();
            return View(genres);
        }
        public class Customer
        {
            [Required(ErrorMessage = "Please enter a name.")]
            [RegularExpression("^[a-zA-Z0-9]+$",
            ErrorMessage = "Name may not contain special characters.")]
            public string Name { get; set; }
            [Required(ErrorMessage = "Please enter a date of birth.")][Range(typeof(DateTime), "1/1/1900", "12/31/9999", ErrorMessage = "Date of birth must be after 1/1/1900.")] public DateTime? DOB { get; set; }
            [Required(ErrorMessage = "Please enter a password.")]
            [StringLength(25)]
            [Compare("ConfirmPassword")] public string Password { get; set; }
            [Required(ErrorMessage = "Please confirm your password.")][Display(Name = "Confirm Password")] public string ConfirmPassword { get; set; }
        }

    }

}