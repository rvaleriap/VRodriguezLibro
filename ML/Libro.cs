using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Libro
    {
        public int IdLibro { get; set; }
        public string Nombre { get; set; }
        public string FechaPublicacion { get; set; }
        public int NumeroPaginas { get; set; }
        public int IdAutor { get; set; }
        public List<Object> Libros { get; set; }
        public ML.Autor Autor { get; set; }
    }
}
