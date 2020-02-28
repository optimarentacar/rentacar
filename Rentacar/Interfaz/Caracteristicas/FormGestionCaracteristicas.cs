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

namespace Rentacar.Interfaz.Caracteristicas
{
    public partial class FormGestionCaracteristicas : Form
    {
        private IRepositorioCaracteristica _repositorioCaracteristica;
        public List<Caracteristica> caracteristicas;
        private Caracteristica caracteristica;
        public bool Cerrado { get; set; }

        public FormGestionCaracteristicas(IRepositorioCaracteristica repositorioCaracteristica)
        {
            _repositorioCaracteristica = repositorioCaracteristica;
            InitializeComponent();
        }

        private async Task Listar()
        {
            try
            {
                this.caracteristicas = await _repositorioCaracteristica.Listar();

            }
            catch (Exception)
            {

            }
        }

        private void RellenarTabla()
        {
            if (this.caracteristicas != null)
            {
                this.caracteristicas.ForEach(c =>
                {
                    tabla.Rows.Add(c.Id, c.Nombre);
                });
            }
        }
        private async void FormGestionAccesorios_Load(object sender, EventArgs e)
        {
            await Listar();
            this.RellenarTabla();
        }

        private void tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                int id = (int)tabla.SelectedRows[0].Cells[0].Value;

                caracteristica = this.caracteristicas
                    .FirstOrDefault(c => c.Id == id);

                tbNombre.Text = caracteristica.Nombre;
                btnEliminar.Enabled = true;
                btnModificar.Enabled = false;
                btnAgregar.Enabled = false;
            }
        }

        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                Caracteristica c = new Caracteristica()
                {
                    Nombre = tbNombre.Text
                };
                ValidacionCaracteristica validator = new ValidacionCaracteristica();

                ValidationResult results = validator.Validate(c);
                if (!results.IsValid)
                {
                    string message = results.Errors[0].ErrorMessage;
                    MessageBox.Show(message, "Error");
                }
                else
                {
                    bool creado = false;
                    try
                    {
                        creado = await _repositorioCaracteristica.Crear(c);
                    }
                    catch (NombreAccesorioYaExisteException nayee)
                    {
                        MessageBox.Show(nayee.Message, "Error");
                    }

                    if (creado)
                    {
                        MessageBox.Show("Característica creada", "Información");
                        await Listar();
                        tabla.Rows.Clear();
                        RellenarTabla();
                    }
                }



            }


        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {


                Caracteristica c = new Caracteristica()
                {
                    Id = (int)tabla.SelectedRows[0].Cells[0].Value,
                    Nombre = tbNombre.Text,

                };
                ValidacionCaracteristica validator = new ValidacionCaracteristica();

                ValidationResult results = validator.Validate(c);
                if (!results.IsValid)
                {
                    string message = results.Errors[0].ErrorMessage;
                    MessageBox.Show(message, "Error");
                }
                else
                {
                    bool modificado = false;
                    try
                    {
                        Console.WriteLine("AAAAAAAAAAAAAAAAAAAAA");
                        modificado = await _repositorioCaracteristica.Modificar(c);
                    }
                    catch (NombreAccesorioYaExisteException nayee)
                    {
                        MessageBox.Show(nayee.Message, "Error");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocurrió un error", "Error");
                    }

                    if (modificado)
                    {
                        MessageBox.Show("Característica modificada", "Información");
                        await Listar();
                        tabla.Rows.Clear();
                        RellenarTabla();
                    }
                }


            }

        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {

                int id = (int)tabla.SelectedRows[0].Cells[0].Value;
                bool borrado = false;
                try
                {
                    bool asignado = await _repositorioCaracteristica
                        .TieneAlquileresAsignados(id);

                    if (asignado)
                    {
                        MessageBox.Show("La característica no se puede eliminar " +
                            "porque tiene alquileres asignados.", "Información");
                    }
                    else
                    {
                        borrado = await _repositorioCaracteristica.Borrar(id);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ocurrió un error", "Error");
                }

                if (borrado)
                {
                    MessageBox.Show("Característica eliminada", "Información");
                    await Listar();
                    tabla.Rows.Clear();
                    RellenarTabla();
                }
            }



        }

        private void FormGestionCaracteristicas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Cerrado = true;
        }
    }
}

