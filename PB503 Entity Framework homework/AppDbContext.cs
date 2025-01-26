using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PB503_Entity_Framework_homework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PB503_Entity_Framework_homework
{
    public class AppDbContext : DbContext
    {
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Book> Books { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=RAUFABASBAYLI\\SQLEXPRESS;Database=PB503EntityFrameworkHomework;Trusted_Connection=true;TrustServerCertificate=true");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
