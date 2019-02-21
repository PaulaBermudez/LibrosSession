using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LibrosSession.Models
{
    [Table("Libros")]
    public class Libro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IdLibro")]
        public int IdLibro { get; set; }
        [Column("Titulo")]
        public String Titulo { get; set; }
        [Column ("Autor")]
        public String Autor { get; set; }
    }
}