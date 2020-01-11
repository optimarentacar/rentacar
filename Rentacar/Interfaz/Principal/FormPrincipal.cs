using Rentacar.Excepciones;
using Rentacar.Interfaz.Clientes;
using Rentacar.Interfaz.Vehiculos;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Principal
{
    public partial class FormPrincipal : Form
    {

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionCliente fgc = Program.container.GetInstance<FormGestionCliente>();
            fgc.ShowDialog();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionVehiculos fgv = Program.container.GetInstance<FormGestionVehiculos>();
            fgv.ShowDialog();
        }
    }
}
