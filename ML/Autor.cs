﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Autor
    {
        public int IdAutor { get; set; }
        public string NombreAutor { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public List<Object> Autores { get; set; }
    }
}
