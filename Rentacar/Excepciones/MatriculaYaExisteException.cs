using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Excepciones
{
    class MatriculaYaExisteException : Exception
    {
        private static readonly string message =
            "Ya existe un e vehículo con la misma matrícula";

        public MatriculaYaExisteException() : base(message)
        {
        }
    }
}
