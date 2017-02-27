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
            SelectList selectedFilms = new SelectList(db.Films, "Id", "Name");
            ViewBag.Films = selectedFilms;
            return View();
        }

        [HttpPost]
        public ViewResult Index(FilmOrder order)
        {


            if (ModelState.IsValid)
            {
                order.FilmProperty = db.Films.Find(order.FilmId);
                order.Price = order.AmountOfDays * order.FilmProperty.Price;
                return View("Thanks", order);
            }
            else
            {
                return View();
            }
        }

    }
}