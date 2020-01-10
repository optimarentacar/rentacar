using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Excepciones
{
    class ModeloVehiculoYaExisteException : Exception
    {
        private static readonly string message = "Ya existe un modelo de vehículo con el mismo nombre";

        public ModeloVehiculoYaExisteException() : base(message)
        {
        }
    }
}
