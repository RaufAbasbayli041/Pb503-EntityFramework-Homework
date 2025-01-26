﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Entity_Framework_homework.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } // navigation property

        public override string ToString()
        {
            return $"{Id} , {Name}";
        }
    }
}
