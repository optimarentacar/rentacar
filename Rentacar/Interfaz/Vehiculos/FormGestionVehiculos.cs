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

                TablaVehiculos.Rows.Clear();
                for (int i = 0; i < Vehiculos.Count; i++)
                {

                    TablaVehiculos.Rows.Add(Vehiculos[i].Matricula, Vehiculos[i].Marca.Nombre,
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
            if (TablaVehiculos.SelectedRows.Count > 0)
            {
                String matricula = TablaVehiculos.SelectedRows[0].Cells[0].Value.ToString();
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
    }
}
