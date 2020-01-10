using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Excepciones
{
    public class NombreCaracteristicaYaExisteException:Exception
    {
        private static readonly string message = "Ya existe una caracerística con el mismo nombre";

        public NombreCaracteristicaYaExisteException() : base(message)
        {
        }
    }
}
