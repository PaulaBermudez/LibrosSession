using LibrosSession.Models;
using LibrosSession.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibrosSession.Controllers
{
    public class LibrosController : Controller
    {
        RepositoryLibros repo;
        public LibrosController()
        {
            this.repo = new RepositoryLibros();
        }
        // GET: Libros
        public ActionResult ListadoLibros(int? id)
        {
            if (id != null)
            {
                List<int> codigoLibro;
                if (Session["LIBROS"] == null)
                {
                    codigoLibro = new List<int>();
                }
                else
                {
                    codigoLibro = Session["LIBROS"] as List<int>;
                }
                codigoLibro.Add(id.Value);
                Session["LIBROS"] = codigoLibro;
            }
            ViewBag.Favoritos = Session["LIBROS"];
            return View(this.repo.GetLibros());
        }

        public ActionResult LibrosFavoritos(int? id)
        {
            List<int>codigos = (List<int>)Session["LIBROS"];
            if (id != null)
            {
                codigos.Remove(id.Value);
            }
            if (codigos.Count() == 0)
            {
                Session["LIBROS"] = null;
            }
            else
            {
                Session["LIBROS"] = codigos;
            }
            if (Session["LIBROS"] != null)
            {
                List<Libro> libros = this.repo.BuscarLibro(codigos);
                return View(libros);
            }
            return View();
        }
    }
}