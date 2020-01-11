using Rentacar.Excepciones;
using Rentacar.Interfaz.Accesorios;
using Rentacar.Interfaz.Caracteristicas;
using Rentacar.Interfaz.Clientes;
using Rentacar.Interfaz.Vehiculos;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Test;
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

        private void button2_Click(object sender, EventArgs e)
        {
            FormTest test = Program.container.GetInstance<FormTest>();
            test.ShowDialog();
        }

        private void accesoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionAccesorios fga = Program.container.GetInstance<FormGestionAccesorios>();
            fga.ShowDialog();
        }

        private void característicasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionCaracteristicas fgc = Program.container
                .GetInstance<FormGestionCaracteristicas>();
            fgc.ShowDialog();
        }
    }
}
