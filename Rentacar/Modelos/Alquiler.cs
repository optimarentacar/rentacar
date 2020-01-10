using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public virtual Vehiculo Vehiculo { get; set; }
        public virtual Cliente Cliente { get; set; }
        public virtual List<Accesorio> Accesorios { get; set; }
        public virtual float CostoTotalAccesorios { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public float Importe { get; set; }
    }
}
