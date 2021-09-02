using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            // return View(movie);
            return Content("Hi Luna");
        }
    }
}