using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Libro
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using(DL.VRodriguezLibroEntities context = new DL.VRodriguezLibroEntities())
                {
                    var query = context.GetAllLibro();
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Libro libro = new ML.Libro();
                            libro.IdLibro = obj.IdLibro;
                            libro.Nombre = obj.Nombre;
                            libro.FechaPublicacion = obj.FechaPublicacion;
                            libro.NumeroPaginas = obj.NumeroPaginas.Value;

                            libro.Autor = new ML.Autor();
                            libro.Autor.IdAutor = obj.IdAutor;
                            libro.Autor.NombreAutor = obj.NombreAutor;

                            result.Objects.Add(libro);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se pudo Mostar la informacion";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.Message = "No se puede visualizar";
            }
            return result;
        }

        public static ML.Result Add(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VRodriguezLibroEntities context = new DL.VRodriguezLibroEntities())
                {
                    int query = context.AddLibro(libro.Nombre, libro.FechaPublicacion, libro.NumeroPaginas, libro.Autor.IdAutor);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se puede agregar";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.Message = "No se puede agregar";
            }
            return result;
        }
        public static ML.Result Delete (ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VRodriguezLibroEntities context = new DL.VRodriguezLibroEntities())
                {
                    int query = context.DeleteLibro(libro.IdLibro);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se puede eliminar";
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.Message = "NO se puede eliminar";
            }
            return result;
        }
        public static ML.Result GetById (int IdLibro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VRodriguezLibroEntities context = new DL.VRodriguezLibroEntities())
                {
                    var query = context.GetByIdLibro(IdLibro);
                    if(query != null)
                    {
                        result.Objects = new List<object>();
                        foreach (var obj in query)
                        {
                            ML.Libro libro = new ML.Libro();
                            libro.IdLibro = obj.IdLibro;
                            libro.Nombre = obj.Nombre;
                            libro.FechaPublicacion = obj.FechaPublicacion;
                            libro.NumeroPaginas = obj.NumeroPaginas.Value;

                            libro.Autor = new ML.Autor();
                            libro.Autor.IdAutor = obj.IdAutor;
                            libro.Autor.NombreAutor = obj.NombreAutor;

                            result.Objects.Add(libro);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se pudo Mostar la informacion";
                    }

                
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
            }
            return result;
        }
        public static ML.Result Update(ML.Libro libro)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.VRodriguezLibroEntities context = new DL.VRodriguezLibroEntities())
                {
                    int query = context.UpdateLibro(libro.IdLibro,libro.Nombre, libro.FechaPublicacion, libro.NumeroPaginas, libro.Autor.IdAutor);
                    if (query >= 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.Message = "No se puede agregar";
                    }
                }
            }
            catch (Exception ex)
            {

            }
            return result;
        }
    }
}
