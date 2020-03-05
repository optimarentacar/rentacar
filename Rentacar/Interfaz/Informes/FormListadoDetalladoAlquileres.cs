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
    public partial class FormListadoDetalladoAlquileres : Form
    {
        public FormListadoDetalladoAlquileres()
        {
            InitializeComponent();
        }

        public async Task Listar(List<Alquiler> alquileres)
        {
            float total = 0f;
            alquileres.ForEach(a =>
            {
                total += a.Importe;

                FlowLayoutPanel.Controls.Add(new ControlListadoDetalladoAlquileres(a));
            });
            
            lbBarra.Text = alquileres.Count.ToString() + " alquileres.      " + total.ToString() + " €";
        }
    }
}
