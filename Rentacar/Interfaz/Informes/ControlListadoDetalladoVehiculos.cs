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
        public ControlListadoDetalladoVehiculos(Vehiculo vehiculo)
        {
            InitializeComponent();
            rellenarDatos(vehiculo);
        }

        private void rellenarDatos(Vehiculo vehiculo)
        {
            pictureBox1.Image = Image.FromFile(vehiculo.PathAbsolutoFoto);
            lbMatricula.Text = vehiculo.Matricula;
            lbModelo.Text = vehiculo.Modelo;
            lbAyo.Text = vehiculo.Anio;
            lbPlazas.Text = vehiculo.Capacidad + " plazas";

            vehiculo.Alquileres.ForEach(a =>
            {
                flowLayoutPanel1.Controls.Add(new ControlListadoAlquileres(a));
                Console.WriteLine(a.FechaFin);
            });
        }
    }
}
