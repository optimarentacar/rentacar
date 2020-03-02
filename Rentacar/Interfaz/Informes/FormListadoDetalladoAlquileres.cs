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
        private int cont;
        public FormListadoDetalladoAlquileres()
        {
            InitializeComponent();
            cont = 0;
        }

        public async Task Listar(List<Alquiler> alquileres)
        {
            alquileres.ForEach(a =>
            {
                FlowLayoutPanel.Controls.Add(new ControlListadoDetalladoAlquileres(a));
                //cont++;
            });
            //TotalAlquileres();
        }

        private void TotalAlquileres()
        {
            lbTotalAlquileres.Text = cont + " alquileres.";
        }
    }
}
