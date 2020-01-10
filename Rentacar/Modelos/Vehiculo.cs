using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Modelos
{
    public class Vehiculo
    {
        public string Matricula { get; set; }
        public Marca Marca { get; set; }
        public string Modelo { get; set; }
        public int Capacidad { get; set; }
        public string Anio { get; set; }
        public float CostoDia { get; set; }
        public string PathFoto { get; set; }
    }
}
