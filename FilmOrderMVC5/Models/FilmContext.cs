using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FilmOrderMVC5.Models
{
    public class FilmContext: DbContext
    {
        public DbSet<Film> Films { get; set; }

        public System.Data.Entity.DbSet<FilmOrderMVC5.Models.FilmOrder> FilmOrders { get; set; }
    }
}