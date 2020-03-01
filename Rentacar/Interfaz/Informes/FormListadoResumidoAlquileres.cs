using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Informes
{
    public partial class FormListadoResumidoAlquileres : Form
    {
        public FormListadoResumidoAlquileres()
        {
            InitializeComponent();
        }

        public async Task Listar(List<Alquiler> alquileres)
        {
            label1.Text = alquileres.Count+" alquileres." ;

            alquileres.ForEach(a =>
            {
                dataGridView1.Rows.Add(a.Vehiculo.Matricula,
                    (a.Vehiculo.Marca.Nombre + " " + a.Vehiculo.Modelo), a.Cliente.Dni,
                    a.Cliente.Nombre,
                    a.FechaInicio.ToString("dd/MM/yyyy"), a.FechaFin.ToString("dd/MM/yyyy"));
            });
        }
    }
}
