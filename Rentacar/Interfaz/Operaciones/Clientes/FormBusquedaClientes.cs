using Rentacar.Excepciones;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Operaciones.Clientes
{
    public partial class FormBusquedaClientes : Form
    {
        private readonly IRepositorioCliente _repositorioCliente;
        private List<Cliente> clientes;

        public FormBusquedaClientes(IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
            InitializeComponent();
        }

        private void rbDni_Click(object sender, EventArgs e)
        {
            labelBusqueda.Text = "Dni";
        }

        private void rbNombre_Click(object sender, EventArgs e)
        {
            labelBusqueda.Text = "Nombre y Apellidos";
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            this.labelClienteNoEncontrado.Visible = false;
            this.clientes = new List<Cliente>();
            string cadena = textBox1.Text;

            if (cbBusqueda.Checked && rbDni.Checked)
            {
                await this.BuscarPorDniExacto(cadena);
            }
            if (cbBusqueda.Checked && rbNombre.Checked)
            {
                await this.BuscarPorNombreExacto(cadena);
            }
            if (!cbBusqueda.Checked && rbDni.Checked)
            {
                await this.BuscarPorDniParecido(cadena);
            }
            if (!cbBusqueda.Checked && rbNombre.Checked)
            {
                await this.BuscarPorNombreParecido(cadena);
            }

            this.RellenarTabla();
        }

        private async Task BuscarPorNombreParecido(string nombre)
        {
            try
            {
                this.clientes = await _repositorioCliente.ObtenerParecidosANombre(nombre);
            }
            catch (Exception)
            {

            }
        }

        private async Task BuscarPorDniParecido(string dni)
        {
            try
            {
                this.clientes = await _repositorioCliente.ObtenerParecidosADni(dni);
            }
            catch (Exception)
            {

            }
        }

        private async Task BuscarPorNombreExacto(string nombre)
        {
            try
            {
                this.clientes = await _repositorioCliente.ObtenerPorNombre(nombre);

                if(this.clientes.Count == 0)
                {
                    this.labelClienteNoEncontrado.Visible = true;
                }
            }
            catch (Exception)
            {

            }
        }

        private async Task BuscarPorDniExacto(string dni)
        {
            try
            {
                Cliente cliente = await _repositorioCliente.ObtenerPorDni(dni);
                this.clientes = new List<Cliente>()
                {
                    cliente
                };
            }
            catch (DatosNoEncontradosException ex)
            {
                this.labelClienteNoEncontrado.Visible = true;
            }
        }

        private void RellenarTabla()
        {
            tabla.Rows.Clear();
            this.clientes.ForEach(c =>
            {
                tabla.Rows.Add(c.Dni, c.Nombre, c.Telefono, c.Domilicio);
            });
        }
    }
}
