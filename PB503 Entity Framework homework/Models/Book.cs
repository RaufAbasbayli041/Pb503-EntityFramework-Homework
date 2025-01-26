using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Entity_Framework_homework.Models
{
    public class Book
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public string Name { get; set; }
        public double SalePrice { get; set; }
        public double CostPrice { get; set; }
        public Genre Genre { get; set; } // navigation property

        public override string ToString()
        {
            return $"{Id}, genre id - {GenreId}, book name - {Name}, sale price - {SalePrice}, cost price - {CostPrice}";
        }

    }
}
