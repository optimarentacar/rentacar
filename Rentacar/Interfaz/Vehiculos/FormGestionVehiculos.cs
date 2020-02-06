using Rentacar.Enums;
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

namespace Rentacar.Interfaz.Vehiculos
{
    public partial class FormGestionVehiculos : Form
    {
        private IRepositorioVehiculo _repositorioVehiculo;
        private IRepositorioMarca _repositorioMarca;
        private List<Vehiculo> Vehiculos;
        private Vehiculo vehiculo;
        private Operacion operacion;

        public FormGestionVehiculos(IRepositorioVehiculo repositorioVehiculo, IRepositorioMarca repositorioMarca)
        {
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioMarca = repositorioMarca;
            InitializeComponent();
        }

        private async void FormGestionVehiculos_Load(object sender, EventArgs e)
        {
            await cargarComboBox();
            await Listar();

        }

        private async Task Listar()
        {
            try
            {
                Vehiculos = await _repositorioVehiculo.Listar();

                Tabla.Rows.Clear();
                for (int i = 0; i < Vehiculos.Count; i++)
                {

                    Tabla.Rows.Add(Vehiculos[i].Matricula, Vehiculos[i].Marca.Nombre,
                        Vehiculos[i].Modelo, Vehiculos[i].Capacidad, Vehiculos[i].Anio, Vehiculos[i].CostoDia);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task cargarComboBox()
        {
            try
            {
                List<Marca> marcas = await _repositorioMarca.Listar();

                comboBoxMarca.DataSource = marcas;
                comboBoxMarca.DisplayMember = "Nombre";
                comboBoxMarca.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        private void TablaVehiculos_SelectionChanged(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count > 0)
            {
                String matricula = Tabla.SelectedRows[0].Cells[0].Value.ToString();
                vehiculo = Vehiculos.FirstOrDefault(v => v.Matricula == matricula);
                textMatricula.Text = vehiculo.Matricula;
                comboBoxMarca.SelectedValue = vehiculo.Marca.Id;
                textModelo.Text = vehiculo.Modelo;
                textAño.Text = vehiculo.Anio;
                textCapacidad.Text = vehiculo.Capacidad.ToString();
                textCosto.Text = vehiculo.CostoDia.ToString();
                FotoVehiculo.Image = Image.FromFile(vehiculo.PathAbsolutoFoto);
            }
        }
        public void limpiar()
        {
            textMatricula.Text = "";
            comboBoxMarca.Text = "";
            textModelo.Text = "";
            textAño.Text = "";
            textCapacidad.Text = "";
            textCosto.Text = "";
        }

        private void activar()
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

            textMatricula.Enabled = false;
            comboBoxMarca.Enabled = false;
            textModelo.Enabled = false;
            textAño.Enabled = false;
            textCapacidad.Enabled = false;
            textCosto.Enabled = false;
            Tabla.Enabled = true;
        }

        private void desactivar()
        {
            Tabla.Enabled = false;

            textMatricula.Enabled = true;
            comboBoxMarca.Enabled = true;
            textModelo.Enabled = true;
            textAño.Enabled = true;
            textCapacidad.Enabled = true;
            textCosto.Enabled = true;

            btnAtras.Enabled = false;
            btnPrimero.Enabled = false;
            btnSiguiente.Enabled = false;
            btnUltimo.Enabled = false;
            btnAñadir.Enabled = false;
            btnModificar.Enabled = false;
            btnEliminar.Enabled = false;

            btnValidar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                Tabla.Rows[0].Selected = true;
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

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (Tabla.Rows.Count > 0)
            {
                Tabla.Rows[Tabla.Rows.Count - 1].Selected = true;
            }
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            limpiar();
            desactivar();
            btnCaracteristicas.Enabled = true;
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

            textMatricula.Enabled = false;
            comboBoxMarca.Enabled = false;
            textModelo.Enabled = false;
            textAño.Enabled = false;
            textCapacidad.Enabled = false;
            textCosto.Enabled = false;

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
                    btnCaracteristicas.Enabled = false;
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
            btnCaracteristicas.Enabled = false;
            activar();
        }

        private async Task<bool> Crear()
        {
            bool creado = false;

            return creado;
        }

        private async Task<bool> Modificar()
        {
            bool modificado = false;

            return modificado;
        }

        private async Task<bool> Eliminar()
        {
            bool borrado = false;
            String matricula = textMatricula.Text;
            try
            {
                if (!(await _repositorioVehiculo.TieneAlquileresAsignados(matricula)))
                {
                    borrado = await _repositorioVehiculo.Borrar(matricula);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return borrado;
        }

        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            FormCaracteristicas fc = new FormCaracteristicas();
            fc.Show();
        }
    }
}
