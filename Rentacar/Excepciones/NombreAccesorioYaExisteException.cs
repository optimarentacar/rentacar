using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Excepciones
{
    public class NombreAccesorioYaExisteException: Exception
    {
        private static readonly string message = "Ya existe un accesorio con el mismo nombre";

        public NombreAccesorioYaExisteException() : base(message)
        {
        }
    }
}
