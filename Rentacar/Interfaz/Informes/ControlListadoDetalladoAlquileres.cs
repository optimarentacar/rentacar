using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentacar.Modelos;

namespace Rentacar.Interfaz.Informes
{
    public partial class ControlListadoDetalladoAlquileres : UserControl
    {
        public ControlListadoDetalladoAlquileres(Alquiler alquiler)
        {
            InitializeComponent();
            rellenarDatos(alquiler);
        }

        private void rellenarDatos(Alquiler alquiler)
        {
            label2.Text = alquiler.Vehiculo.Matricula;
        }
    }
}
