using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmOrderMVC5.Models
{
    public class FilmDbInitializer : DropCreateDatabaseAlways<FilmContext>
    {
        protected override void Seed(FilmContext db)
        {
            db.Films.Add(new Film() { Id = 0, Name = "Toy Story", Price = 100 });
            db.Films.Add(new Film() { Id = 1, Name = "Nemo", Price = 200 });
            db.Films.Add(new Film() { Id = 2, Name = "Alladin", Price = 300 });
            db.Films.Add(new Film() { Id = 3, Name = "Cinderella", Price = 400 });

            base.Seed(db);
        }
    }
}