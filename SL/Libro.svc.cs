using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Libro" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Libro.svc or Libro.svc.cs at the Solution Explorer and start debugging.
    public class Libro : ILibro
    {
        public ML.Result GetAll()
        {
            ML.Result result = BL.Libro.GetAll();
            if (result.Correct)
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
