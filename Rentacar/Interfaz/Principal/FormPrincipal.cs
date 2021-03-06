﻿using Rentacar.Excepciones;
using Rentacar.Interfaz.Accesorios;
using Rentacar.Interfaz.Caracteristicas;
using Rentacar.Interfaz.Clientes;
using Rentacar.Interfaz.Informes;
using Rentacar.Interfaz.Operaciones.Alquiler;
using Rentacar.Interfaz.Operaciones.Clientes;
using Rentacar.Interfaz.Operaciones.Vehiculos;
using Rentacar.Interfaz.Vehiculos;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Repositorio.Repositorios;
using System;
using System.Collections.Generic;
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

        private void buscarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusquedaClientes fbc = Program.container
                .GetInstance<FormBusquedaClientes>();
            fbc.ShowDialog();
        }

        private void buscarPorMatrículaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusquedaVehiculosPorMatricula fbvm = Program.container
                .GetInstance<FormBusquedaVehiculosPorMatricula>();
            fbvm.ShowDialog();
        }

        private void buscarPorFiltrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBusquedaVehiculosPorFiltros fbvf = Program.container
                .GetInstance<FormBusquedaVehiculosPorFiltros>();
            fbvf.ShowDialog();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionMarcas gm = Program.container.GetInstance<FormGestionMarcas>();
            gm.ShowDialog();
        }


        private void vehículosAlquiladosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlquilerVehiculos fav = Program.container.GetInstance<FormAlquilerVehiculos>();
            fav.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVehiculosAlquiler gm = Program.container.GetInstance<FormVehiculosAlquiler>();
            gm.ShowDialog();

        }

        private void listadoDeAlquileresPorFechaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAlquilerFecha faf = Program.container.GetInstance<FormAlquilerFecha>();
            faf.ShowDialog();
        }

       

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoClientes lc = Program.container.GetInstance<FormListadoClientes>();
            lc.ShowDialog();
        }

        private void listadoResumidoDeVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoResumidoVehiculos Lrv = Program.container.GetInstance<FormListadoResumidoVehiculos>();
            Lrv.ShowDialog();
        }

        private void listadoDetalladoDeVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoDetalladoVehiculos Lrv = Program.container.GetInstance<FormListadoDetalladoVehiculos>();
            Lrv.ShowDialog();
        }

        private void listadoDeAlquileresPorVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoAlquilerPorVehiculos lc = Program.container.GetInstance<FormListadoAlquilerPorVehiculos>();
            lc.ShowDialog();
        }
    }
}
