using MVCAppDemoWithAuthtentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAppDemoWithAuthtentication.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
       
        private ApplicationDbContext _context;
        public MovieController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Movie
        public ActionResult Index1()
        {
            var movies = _context.Movies;
            return View(movies);
        }
        public object Details(int id)
        {
            var singleMovie = _context.Movies;
            if (singleMovie == null)

                return HttpNotFound();
            return View(singleMovie);

        }

        private void SingleOrDefault(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}