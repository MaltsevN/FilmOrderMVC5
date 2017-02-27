using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FilmOrderMVC5.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        
        public Film()
        {

        }
        public Film(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }
        public override string ToString()
        {
            string res = Name.ToString();
            res += " | ";
            res += Price.ToString();
            res += " UAH";
            return res;
        }
    }
}