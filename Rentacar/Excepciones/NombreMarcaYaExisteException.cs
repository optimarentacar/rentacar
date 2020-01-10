using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Excepciones
{
    class NombreMarcaYaExisteException : Exception
    {
        private static readonly string message = "Ya existe una marca con el mismo nombre";

        public NombreMarcaYaExisteException() : base(message)
        {
        }
    }
}
