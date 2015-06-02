using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MvcBook.Models
{
    public class Book
    {
        public int ID { get; set; }

        
        public string Title { get; set; }

        public string Author { get; set; }

       
        public string Genre { get; set; }

       

        public decimal Price { get; set; }
        
       

    }
    
    public class BookDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
    }
}