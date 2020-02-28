
using FluentValidation.Results;
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

namespace Rentacar.Interfaz.Vehiculos
{
    public partial class FormGestionMarcas : Form
    {
        private IRepositorioMarca _repositorioMarca;
        private List<Marca> Marcas;

        public FormGestionMarcas(IRepositorioMarca repositorioMarca)
        {
            InitializeComponent();
            _repositorioMarca = repositorioMarca;
        }

        private async void FormGestionMarcas_Load(object sender, EventArgs e)
        {
            await Listar();
        }
        private async Task Listar()
        {
            try
            {
                Marcas = await _repositorioMarca.Listar();
                listBoxMarcas.DataSource = Marcas;
                listBoxMarcas.DisplayMember = "Nombre";
                listBoxMarcas.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void listBoxMarcas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMarcas.Items.Count > 0)
            {
                textBoxNombre.Text = (listBoxMarcas.SelectedItem as Marca).Nombre; 
            }
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            bool creado = false;

            Marca m = new Marca()
            {
                Nombre = textBoxNombre.Text
            };

             ValidacionMarca validator = new ValidacionMarca();
            ValidationResult results = validator.Validate(m);
            if (!results.IsValid)
            {
                string mensaje = results.Errors[0].ErrorMessage;
                MessageBox.Show(mensaje);
            }
            else
            {
                try
                {
                    creado = await _repositorioMarca.Crear(m);
                    await Listar();
                }
                catch(NombreMarcaYaExisteException nmyee)
                {
                    Console.WriteLine(nmyee.Message);
                    MessageBox.Show("La marca ya existe.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ocurrió un error.");
                }
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            bool modificado = false;

            Marca m = new Marca()
            {
                Id = (int)listBoxMarcas.SelectedValue,
                Nombre = textBoxNombre.Text
            };

            ValidacionMarca validator = new ValidacionMarca();
            ValidationResult results = validator.Validate(m);
            if (!results.IsValid)
            {
                string mensaje = results.Errors[0].ErrorMessage;
                MessageBox.Show(mensaje);
            }
            else
            {
                try
                {
                    modificado = await _repositorioMarca.Modificar(m);
                    await Listar();

                }
                catch (NombreMarcaYaExisteException nmyee)
                {
                    Console.WriteLine(nmyee.Message);
                    MessageBox.Show("La marca ya existe.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ocurrió un error.");
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = (int)listBoxMarcas.SelectedValue;

            bool borrado;
            try
            {
                if (!(await _repositorioMarca.TieneVehiculosAsignados(id)))
                {

                    borrado = await _repositorioMarca.Borrar(id);
                    await Listar();
                }
                else
                {
                    MessageBox.Show("La marca no se puede borrar porque " +
                        "tiene vehículos asignados.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }
    }
}
