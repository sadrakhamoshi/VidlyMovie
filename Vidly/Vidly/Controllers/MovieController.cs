using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Moveis;

namespace Vidly.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{Name="sherk"},
                new Movie{Name="wall-e"}
            };

            var m = new ListOfMovei
            {
                //MyMovie = movies
            };
            return View(m);
        }
    }
}