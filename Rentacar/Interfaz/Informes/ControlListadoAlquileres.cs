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
    public partial class ControlListadoAlquileres : UserControl
    {
        public ControlListadoAlquileres(Alquiler alquiler)
        {
            InitializeComponent();
            RellenarDatos(alquiler);
        }

        private void RellenarDatos(Alquiler alquiler)
        {
            lbDni.Text = alquiler.Cliente.Dni;
            lbNombre.Text = alquiler.Cliente.Nombre;
            lbFechaInicio.Text = alquiler.FechaInicio.ToString("dd/MM/yyyy");
            lbFechaFin.Text = alquiler.FechaFin.ToString("dd/MM/yyyy");
            lbAlquiler.Text = (alquiler.Importe - alquiler.CostoTotalAccesorios).ToString()+ " €";
            lbAccesorios.Text = alquiler.CostoTotalAccesorios.ToString() + " €";
            lbTotal.Text = alquiler.Importe.ToString() + " €";
        }
    }
}
