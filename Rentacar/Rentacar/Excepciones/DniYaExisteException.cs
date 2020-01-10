using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Excepciones
{
    public class DniYaExisteException : Exception
    {
        private static readonly string message = "Ya existe un cliente con el mismo Dni";

        public DniYaExisteException() : base(message)
        {
        }
    }
}
