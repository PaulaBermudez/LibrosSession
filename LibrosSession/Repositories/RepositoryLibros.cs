using LibrosSession.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LibrosSession.Repositories
{
    public class RepositoryLibros
    {
        LibrosVTContext context;
        public RepositoryLibros() {
            this.context = new LibrosVTContext();
        }

        public List<Libro> GetLibros()
        {
            return this.context.Libros.ToList();
        }

        public List<Libro> BuscarLibro(List<int> codigos)
        {
            var consulta = from datos in context.Libros
                           where codigos.Contains(datos.IdLibro)
                           select datos;
            return consulta.ToList();
        }
    }
}