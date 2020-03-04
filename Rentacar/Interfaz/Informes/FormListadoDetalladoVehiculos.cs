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

        public FormListadoDetalladoVehiculos(IRepositorioVehiculo repositorioVehiculo, IRepositorioAlquiler repositorioAlquiler)
        {
            InitializeComponent();
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioAlquiler = repositorioAlquiler;
        }

        private async Task Listar()
        {
            List<Vehiculo> vehiculos = null;
            try
            {
               vehiculos = await _repositorioVehiculo.Listar();


                vehiculos.ForEach(async v =>
                {
                    List<Alquiler> alquileres = await _repositorioAlquiler
                            .ListarConClientesPorVehiculo(v.Matricula);
                    v.Alquileres = alquileres;
                });

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
            
            vehiculos.ForEach(v =>
            {
                FlowLayoutPanel.Controls.Add(new ControlListadoDetalladoVehiculos(v));
                Console.WriteLine(v.Alquileres.Count);
            });
        }

        private async void FormListadoDetalladoVehiculos_Load(object sender, EventArgs e)
        {
            await Listar();
        }
    }
}
