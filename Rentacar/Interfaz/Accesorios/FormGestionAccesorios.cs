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

namespace Rentacar.Interfaz.Accesorios
{
    public partial class FormGestionAccesorios : Form
    {
        private IRepositorioAccesorio _repositorioAccesorio;
        private List<Accesorio> accesorios;
        private Accesorio accesorio;

        public FormGestionAccesorios(IRepositorioAccesorio repositorioAccesorio)
        {
            _repositorioAccesorio = repositorioAccesorio;
            InitializeComponent();
        }

        private async Task Listar()
        {
            try
            {
                this.accesorios = await _repositorioAccesorio.Listar();


            }
            catch (Exception)
            {

            }
        }

        private void RellenarTabla()
        {
            if (this.accesorios != null)
            {
                this.accesorios.ForEach(a =>
                {
                    tabla.Rows.Add(a.Id, a.Nombre, a.Costo);
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

                accesorio = this.accesorios
                    .FirstOrDefault(a => a.Id == id);

                tbNombre.Text = accesorio.Nombre;
                tbPrecio.Text = accesorio.Costo.ToString();
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
                float costo = 0f;
                try
                {
                    costo = float.Parse(tbPrecio.Text);
                    Accesorio a = new Accesorio()
                    {
                        Nombre = tbNombre.Text,
                        Costo = costo
                    };
                    ValidacionAccesorio validator = new ValidacionAccesorio();

                    ValidationResult results = validator.Validate(a);
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
                            creado = await _repositorioAccesorio.Crear(a);
                        }
                        catch (NombreAccesorioYaExisteException nayee)
                        {
                            MessageBox.Show(nayee.Message, "Error");
                        }

                        if (creado)
                        {
                            MessageBox.Show("Accesorio creado", "Información");
                            await Listar();
                            tabla.Rows.Clear();
                            RellenarTabla();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El precio no es correcto", "Error");
                }


            }


        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            if (tabla.SelectedRows.Count > 0)
            {
                float costo = 0f;

                try
                {
                    costo = float.Parse(tbPrecio.Text);

                    Accesorio a = new Accesorio()
                    {
                        Id = (int)tabla.SelectedRows[0].Cells[0].Value,
                        Nombre = tbNombre.Text,
                        Costo = costo
                    };
                    ValidacionAccesorio validator = new ValidacionAccesorio();

                    ValidationResult results = validator.Validate(a);
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
                            modificado = await _repositorioAccesorio.Modificar(a);
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
                            MessageBox.Show("Accesorio modificado", "Información");
                            await Listar();
                            tabla.Rows.Clear();
                            RellenarTabla();
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("El precio no es correcto", "Error");
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
                    bool asignado = await _repositorioAccesorio
                        .TieneAlquileresAsignados(id);

                    Console.WriteLine("AAAAAAAAAAA");
                    if (asignado)
                    {
                        MessageBox.Show("El accesorio no se puede eliminar " +
                            "porque tiene alquileres asignados.", "Información");
                    }
                    else
                    {
                        borrado = await _repositorioAccesorio.Borrar(id);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Ocurrió un error", "Error");
                }

                if (borrado)
                {
                    MessageBox.Show("Accesorio eliminado", "Información");
                    await Listar();
                    tabla.Rows.Clear();
                    RellenarTabla();
                }
            }



        }
    }
}

