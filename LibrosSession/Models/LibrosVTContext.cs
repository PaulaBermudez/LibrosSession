using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LibrosSession.Models
{
    public class LibrosVTContext : DbContext
    {
        public LibrosVTContext() : base("name=cadenalibro") { }
        public DbSet<Libro> Libros { get; set; }
        
    }
}