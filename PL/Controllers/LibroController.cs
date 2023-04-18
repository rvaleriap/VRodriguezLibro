using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class LibroController : Controller
    {
        // GET: Libro
        public ActionResult GetAll()
        {
            ML.Result result =  BL.Libro.GetAll();
            ML.Libro libro = new ML.Libro();
            if (result.Correct)
            {
                libro.Libros = result.Objects;
                return View(libro);
            }
            else
            {
                return View(libro);
            }
           
        }
        [HttpGet]
        public ActionResult Delete (ML.Libro libro)
        {
            ML.Result result = BL.Libro.Delete(libro);
            if (result.Correct)
            {
                ViewBag.Message = "Eliminado";
                return View("Modal");
            }
            else
            {
                ViewBag.Message = "No se ha eliminado el registro";
                return View("Modal");
            }
        }
        [HttpGet]
        public ActionResult Form(int? IdLibro)
        {
            ML.Libro libro = new ML.Libro();

            if (IdLibro == null)
            {
                return View(libro);
            }
            else
            {
                ML.Result result = BL.Libro.GetById(IdLibro.Value);
                if (result.Correct)
                {
                    libro = (ML.Libro)result.Object;
                    return View(libro);
                }
                else
                {
                    ViewBag.Message = "ocurrio un problema";
                    return View("Modal");

                }
            }

        }
        [HttpPost]
        public ActionResult Form(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            if (libro.IdLibro == 0)
            {
                result = BL.Libro.Add(libro);

                if (result.Correct)
                {
                    ViewBag.Message = "Registrado con éxito";
                    return View("Modal");
                }
                else
                {
                    ViewBag.Message = "ocurrio problema";
                    return View("Modal");
                }
            }
            else
            {
                result = BL.Libro.Update(libro);
                if (result.Correct)
                {
                    ViewBag.Message = "actualizado";
                    return View("Modal");
                }
                else
                {
                    ViewBag.Message = "ocurrio un problema";
                    return View("Modal");
                }
            }

        }
    }
}