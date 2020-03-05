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

namespace Rentacar.Interfaz.Informes
{
    public partial class FormListadoDetalladoVehiculos : Form
    {
        private IRepositorioVehiculo _repositorioVehiculo;
        private IRepositorioAlquiler _repositorioAlquiler;
        private IRepositorioCaracteristica _repositorioCaracteristica;

        public FormListadoDetalladoVehiculos(IRepositorioVehiculo repositorioVehiculo, IRepositorioAlquiler repositorioAlquiler, IRepositorioCaracteristica repositorioCaracteristica)
        {
            InitializeComponent();
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioAlquiler = repositorioAlquiler;
            _repositorioCaracteristica = repositorioCaracteristica;
        }

        public async Task Listar()
        {
            List<Vehiculo> vehiculos = null;
            try
            {
                vehiculos = await _repositorioVehiculo.ObtenerAlquiladosDistinct();
               

                vehiculos.ForEach(async v =>
                {
                    List<Alquiler> alquileres = await _repositorioAlquiler
                            .ListarConClientesPorVehiculo(v.Matricula);
                    v.Alquileres = alquileres;
                    List<Caracteristica> c = await _repositorioCaracteristica.Listar();
                    v.Caracteristicas = c;
                });
                lbCantidad.Text = vehiculos.Count.ToString() + " Vehículos";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }

            vehiculos.ForEach(v =>
            {
                flowLayoutPanel1.Controls.Add(new ControlListadoDetalladoVehiculos(v));
            });
        }

        private async void FormListadoDetalladoVehiculos_Load(object sender, EventArgs e)
        {
            await Listar();
        }
    }
}
