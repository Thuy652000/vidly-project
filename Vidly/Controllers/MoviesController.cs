using System;
using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private IEnumerable<Movie> movies = new List<Movie>
        {
            new Movie()
            {
                Id = 1,
                Name = "Shrek!"
            }
        };
        // GET
        public ActionResult Index()
        {
            var viewModel = movies;
            
            return View(movies);
        }
    }
}