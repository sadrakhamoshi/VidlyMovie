using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Name = "Sherek",
                Id = 1
            };
            List<Movie> movies = new List<Movie>()
            {
                movie,
                new Movie(){Name="SDj"}
            };
            return View(movies);
            //return RedirectToAction("Index", "Home",new { page=1 , sortby="name"});
        }
        public ActionResult Edit(string id)
        {
            return Content("id =" + id);
        }
        public ActionResult Index(string name, int? id)
        {
            if (!id.HasValue)
                id = 7;
            if (string.IsNullOrWhiteSpace(name))
                name = "sadra";
            return Content(id + " " + name);
        }
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleasedDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}