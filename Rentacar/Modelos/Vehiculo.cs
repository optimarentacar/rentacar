using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public string PathAbsolutoFoto
        {
            get => Application.StartupPath + PathFoto;
        }
        public List<Caracteristica> Caracteristicas { get; set; }
        public List<Alquiler> Alquileres { get; set; }
    }
}
