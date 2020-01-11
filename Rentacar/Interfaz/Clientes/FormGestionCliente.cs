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

namespace Rentacar.Interfaz.Clientes
{
    public partial class FormGestionCliente : Form
    {
        private IRepositorioCliente _repositorioCliente;
        private List<Cliente> Clientes;
        private Cliente cliente;

        public FormGestionCliente(IRepositorioCliente repositorioCliente)
        {
            _repositorioCliente = repositorioCliente;
            InitializeComponent();
        }

        private async void FormGestionCliente_Load(object sender, EventArgs e)
        {
            await Listar();
        }

        private async Task Listar()
        {
            try
            {
                Clientes = await _repositorioCliente.Listar();

                Tabla.Rows.Clear();
                for (int i = 0; i < Clientes.Count; i++)
                {
                    Tabla.Rows.Add(Clientes[i].Dni, Clientes[i].Nombre, Clientes[i].Telefono, Clientes[i].Domilicio);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if(Tabla.SelectedRows.Count > 0)
            {
                String dni = Tabla.SelectedRows[0].Cells[0].Value.ToString();
                cliente = Clientes.FirstOrDefault(c => c.Dni == dni);
                textDni.Text = cliente.Dni;
                textNombreApellido.Text = cliente.Nombre;
                textTelefono.Text = cliente.Telefono; 
                textDomicilio.Text = cliente.Domilicio;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Tabla.SelectionChanged -= Tabla_SelectionChanged;
            Desactivar();
        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            bool modificado = false;
            Cliente C = new Cliente()
            {
                Dni = textDni.Text,
                Nombre = textNombreApellido.Text,
                Telefono = textTelefono.Text,
                Domilicio = textDomicilio.Text
            };

            //TODO validacion

            try
            {
                modificado = await _repositorioCliente.Modificar(C);
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            if (modificado == true)
            {
                await Listar();
            }
            Activar();
            limpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Tabla.SelectionChanged += Tabla_SelectionChanged;
        }

        public void limpiar()
        {
            textDni.Text = "";
            textNombreApellido.Text = "";
            textTelefono.Text = "";
            textDomicilio.Text = "";
        }

        public void Activar()
        {
            btnCancelar.Enabled = false;
            btnValidar.Enabled = false;
            btnPrimero.Enabled = true;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;
            btnAñadir.Enabled = true;
            btnEliminar.Enabled = true;

            textNombreApellido.Enabled = false;
            textTelefono.Enabled = false;
            textDomicilio.Enabled = false;
        }

        public void Desactivar()
        {
            btnCancelar.Enabled = true;
            btnValidar.Enabled = true;
            btnPrimero.Enabled = false;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnAñadir.Enabled = false;
            btnEliminar.Enabled = false;

            textNombreApellido.Enabled = true;
            textTelefono.Enabled = true;
            textDomicilio.Enabled = true;
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            Desactivar();
        }
    }
}
