using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Excepciones
{
    public class DatosNoEncontradosException : Exception
    {
        public DatosNoEncontradosException(string message) : base(message)
        {
        }
    }
}
