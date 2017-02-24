using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FilmOrderMVC5.Models;

namespace FilmOrderMVC5.Controllers
{
    public class HomeController : Controller
    {
        FilmContext db = new FilmContext();

        [HttpGet]
        public ViewResult Index()
        {
            IEnumerable<Film> films = db.Films;

            //List<Film> films = new List<Film>();

            //films.Add(new Film("Toy Story", 200));
            //films.Add(new Film("Nemo", 250));
            //films.Add(new Film("Alladin", 300));
            //films.Add(new Film("Cinderella", 350));

            //SelectList filmsSelList = new SelectList(films, "Price", "Name");
            ViewBag.Films = films;
            return View();
        }

        [HttpPost]
        public ViewResult Index(FilmOrder order)
        {
            if (ModelState.IsValid)
            {
                return View(order);
            }
            else
            {
                return View();
            }
        }

    }
}