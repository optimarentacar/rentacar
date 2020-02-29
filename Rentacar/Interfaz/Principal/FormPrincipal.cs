using Rentacar.Excepciones;
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
using Rentacar.Test;
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

        private async void button2_Click(object sender, EventArgs e)
        {

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
            faf.Show();
        }

        private async void listadoDeAlquileresPorVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ///CODIGO DE ACCESO A BASE DE DATOS
            ///
            try
            {
                ///PRIMERO SE SACA LA LISTA DE VEHICULOS
                ///PARA PROBAR NO HAGO LA INYECCION DE DEPENDENCIA 
                List<Vehiculo> vehiculos = await new RepositorioVehiculo().Listar();

                ///POR CADA VEHICULO SACO SUS ALQUILERES CON DATOS DE CADA CLIENTE

                vehiculos.ForEach(async v =>
                {
                    List<Alquiler> alquileres = await new RepositorioAlquiler()
                            .ListarConClientesPorVehiculo(v.Matricula);
                    v.Alquileres = alquileres;
                });

                
                ///RELLENAR LA TABLA , CADA VEHICULO CONTIENE UNA LISTA DE ALQUILERES,
                ///Y CADA ALQUILER CONTIENE UN OBJETO CLIENTE
                ///

            }catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void listadoDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoClientes lc = Program.container.GetInstance<FormListadoClientes>();
            lc.Show();
        }

        private void listadoResumidoDeVehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListadoResumidoVehiculos Lrv = Program.container.GetInstance<FormListadoResumidoVehiculos>();
            Lrv.Show();
        }
    }
}
