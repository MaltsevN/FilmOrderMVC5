using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FilmOrderMVC5.Models
{
    public class FilmOrder
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please, enter your name")]
        public string RersonName { get; set; }

        [Required(ErrorMessage = "Please, choose film")]
        public Film OrderFilm { get; set; }

        [Required(ErrorMessage = "Please, enter amount of days")]
        public int AmountOfDays { get; set; }
    }
}