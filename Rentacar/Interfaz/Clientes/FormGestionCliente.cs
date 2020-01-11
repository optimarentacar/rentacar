using FluentValidation.Results;
using Rentacar.Enums;
using Rentacar.Excepciones;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Validacion;
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
        private Operacion operacion;

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
            if (Tabla.SelectedRows.Count > 0)
            {
                String dni = Tabla.SelectedRows[0].Cells[0].Value.ToString();
                cliente = Clientes.FirstOrDefault(c => c.Dni == dni);
                textDni.Text = cliente.Dni;
                textNombreApellido.Text = cliente.Nombre;
                textTelefono.Text = cliente.Telefono;
                textDomicilio.Text = cliente.Domilicio;
            }
        }
        private void btnAñadir_Click(object sender, EventArgs e)
        {
            limpiar();
            desactivar();
            textDni.Enabled = true;
            operacion = Operacion.CREAR;

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            desactivar();
            Tabla.Enabled = true;

            btnPrimero.Enabled = true;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;

            textNombreApellido.Enabled = false;
            textTelefono.Enabled = false;
            textDomicilio.Enabled = false;

            operacion = Operacion.ELIMINAR;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            desactivar();
            operacion = Operacion.MODIFICAR;
        }

        private async void btnValidar_Click(object sender, EventArgs e)
        {
            if (operacion == Operacion.MODIFICAR)
            {
                if (await this.Modificar() == true)
                {
                    await Listar();
                    activar();
                    limpiar();
                } 
            }
            if (operacion == Operacion.CREAR)
            {
                if (await this.Crear() == true)
                {
                    await Listar();
                    activar();
                    limpiar();
                }
            }
            if (operacion == Operacion.ELIMINAR)
            {               
                if (await this.Eliminar() == true)
                {
                    await Listar();
                    activar();
                    limpiar();
                }
            }
        }
    
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiar();
            activar();
        }

        public void limpiar()
        {
            textDni.Text = "";
            textNombreApellido.Text = "";
            textTelefono.Text = "";
            textDomicilio.Text = "";
        }

        public void activar()
        {
            btnCancelar.Enabled = false;
            btnValidar.Enabled = false;
            btnPrimero.Enabled = true;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = true;
            btnUltimo.Enabled = true;
            btnAñadir.Enabled = true;
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;

            textNombreApellido.Enabled = false;
            textTelefono.Enabled = false;
            textDomicilio.Enabled = false;
            textDni.Enabled = false;
            Tabla.Enabled = true;
        }

        public void desactivar()
        {
            btnCancelar.Enabled = true;
            btnValidar.Enabled = true;
            btnPrimero.Enabled = false;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnAñadir.Enabled = false;
            btnEliminar.Enabled = false;
            btnModificar.Enabled = false;

            textNombreApellido.Enabled = true;
            textTelefono.Enabled = true;
            textDomicilio.Enabled = true;
            Tabla.Enabled = false;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                Tabla.Rows[0].Selected = true;
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                Tabla.Rows[Tabla.Rows.Count - 1].Selected = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                if (Tabla.SelectedRows[0].Index > 0)
                {
                    Tabla.Rows[Tabla.SelectedRows[0].Index - 1].Selected = true;
                }
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                if (Tabla.SelectedRows[0].Index < Tabla.Rows.Count - 1)
                {
                    Tabla.Rows[Tabla.SelectedRows[0].Index + 1].Selected = true;
                }
            }
        }

        private async Task<bool> Crear()
        {
            bool creado = false;
            Cliente C = new Cliente()
            {
                Dni = textDni.Text,
                Nombre = textNombreApellido.Text,
                Telefono = textTelefono.Text,
                Domilicio = textDomicilio.Text
            };

            ValidacionCliente validator = new ValidacionCliente();
            ValidationResult results = validator.Validate(C);

            if (!results.IsValid)
            {
                string mensaje = results.Errors[0].ErrorMessage;
                Console.WriteLine(mensaje);
            }
            else
            {
                try
                {
                    creado = await _repositorioCliente.Crear(C);
                }
                catch (DniYaExisteException dyee)
                {
                    MessageBox.Show(dyee.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return creado;
        }

        private async Task<bool> Modificar()
        {
            bool modificado = false;
            Cliente C = new Cliente()
            {
                Dni = textDni.Text,
                Nombre = textNombreApellido.Text,
                Telefono = textTelefono.Text,
                Domilicio = textDomicilio.Text
            };

            ValidacionCliente validator = new ValidacionCliente();
            ValidationResult results = validator.Validate(C);
            if (!results.IsValid)
            {
                string mensaje = results.Errors[0].ErrorMessage;
                Console.WriteLine(mensaje);
            }
            else
            {
                try
                {
                    modificado = await _repositorioCliente.Modificar(C);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
            }
            return modificado;
        }

        private async Task<bool> Eliminar()
        {
            bool borrado = false;
            String dni = textDni.Text;
            try
            {
                borrado = await _repositorioCliente.Borrar(dni);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return borrado;
        }
    }
}