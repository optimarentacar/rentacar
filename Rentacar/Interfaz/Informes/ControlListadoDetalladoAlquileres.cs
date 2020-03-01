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
        private DateTime inicio;
        private DateTime fin;
        public ControlListadoDetalladoAlquileres(Alquiler alquiler)
        {
            InitializeComponent();
            rellenarDatos(alquiler);
        }

        private void rellenarDatos(Alquiler alquiler)
        {
            inicio = alquiler.FechaInicio;
            fin = alquiler.FechaFin;

            lbFechaInicio.Text = alquiler.FechaInicio.ToString("dd/MM/yyyy");
            lbFechaFin.Text = alquiler.FechaFin.ToString("dd/MM/yyyy");
            lbTotalDias.Text = "(" + (fin - inicio).Days + " dias)";

            lbMatricula.Text = alquiler.Vehiculo.Matricula;
            lbModelo.Text = alquiler.Vehiculo.Modelo;
            lbPlazas.Text = alquiler.Vehiculo.Capacidad.ToString() + " plazas";
            lbAyo.Text = "Año " + alquiler.Vehiculo.Anio;

            lbDni.Text = alquiler.Cliente.Dni;
            lbNombre.Text = alquiler.Cliente.Nombre;
            lbDireccion.Text = alquiler.Cliente.Domilicio;
            lbTelefono.Text = alquiler.Cliente.Telefono;

            lbCantidadDias.Text = (alquiler.Importe - alquiler.CostoTotalAccesorios).ToString() + " €";
            lbTotalAccesorios.Text = alquiler.CostoTotalAccesorios.ToString()+ " €";
            lbTotal.Text = alquiler.Importe.ToString() + " €";

            pictureBox.Image = Image.FromFile(alquiler.Vehiculo.PathAbsolutoFoto);
        }
    }
}
