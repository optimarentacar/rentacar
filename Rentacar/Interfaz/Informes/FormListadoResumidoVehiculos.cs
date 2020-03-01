using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Informes
{
    public partial class FormListadoResumidoVehiculos : Form
    {
        private readonly IRepositorioVehiculo _repositorioVehiculo;
        private List<Vehiculo> Vehiculos;
        public FormListadoResumidoVehiculos(IRepositorioVehiculo repositorioVehiculo)
        {
            InitializeComponent();
            _repositorioVehiculo = repositorioVehiculo;
        }

        private async void FormListadoVehiculos_Load(object sender, EventArgs e)
        {
            await Listar();
            TotalVehiculos();
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

        private void TotalVehiculos()
        {
            Total.Text = (Tabla.Rows.Count.ToString()) + " Vehículos.";
        }
    }
}
