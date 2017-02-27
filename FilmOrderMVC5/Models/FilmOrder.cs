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
        public string PersonName { get; set; }

        [Required(ErrorMessage = "Please, choose film")]
        public int FilmId { get; set; }

        public Film FilmProperty { get; set; }
        
        [Required(ErrorMessage = "Please, enter amount of days")]
        public int AmountOfDays { get; set; }

        public double Price { get; set; }
    }
}