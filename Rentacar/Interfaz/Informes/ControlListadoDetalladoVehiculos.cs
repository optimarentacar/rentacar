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
    public partial class ControlListadoDetalladoVehiculos : UserControl
    {
        public ControlListadoDetalladoVehiculos(Alquiler alquiler)
        {
            InitializeComponent();
            rellenarDatos(alquiler);
        }

        private void rellenarDatos(Alquiler alquiler)
        {
            pictureBox1.Image = Image.FromFile(alquiler.Vehiculo.PathAbsolutoFoto);
            lbMatricula.Text = alquiler.Vehiculo.Matricula;
            lbModelo.Text = alquiler.Vehiculo.Modelo;
            lbAyo.Text = alquiler.Vehiculo.Anio;
            lbPlazas.Text = alquiler.Vehiculo.Capacidad + " plazas";

        }
    }
}
