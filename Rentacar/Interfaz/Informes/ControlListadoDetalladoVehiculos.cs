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
using Rentacar.Repositorio.Interfaces;

namespace Rentacar.Interfaz.Informes
{
    public partial class ControlListadoDetalladoVehiculos : UserControl
    {

        public ControlListadoDetalladoVehiculos(Vehiculo vehiculo)
        {
            InitializeComponent();
            rellenarDatos(vehiculo);
        }

        public async Task rellenarDatos(Vehiculo vehiculo)
        {
            pictureBox1.Image = Image.FromFile(vehiculo.PathAbsolutoFoto);
            lbMatricula.Text = vehiculo.Matricula;
            lbMarca.Text = vehiculo.Marca.Nombre;
            lbModelo.Text = vehiculo.Modelo;
            lbAyo.Text = vehiculo.Anio;
            lbPlazas.Text = vehiculo.Capacidad.ToString() + " Plazas";
            lbCostoDia.Text = vehiculo.CostoDia.ToString() + " €";

            vehiculo.Caracteristicas.ForEach(a =>
            {
                flowLayoutPanel1.Controls.Add(new ControlListadoCaracteristicas(a));
            });
        }
    }
}
