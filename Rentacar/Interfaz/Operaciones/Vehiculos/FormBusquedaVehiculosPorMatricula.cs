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

namespace Rentacar.Interfaz.Operaciones.Vehiculos
{
    public partial class FormBusquedaVehiculosPorMatricula : Form
    {
        private readonly IRepositorioVehiculo _repositorioVehiculo;
        private List<Vehiculo> vehiculos;

        public FormBusquedaVehiculosPorMatricula(IRepositorioVehiculo repositorioVehiculo)
        {
            _repositorioVehiculo = repositorioVehiculo;
            InitializeComponent();
        }

        private async void FormBusquedaVehiculosPorMatricula_Load(object sender, EventArgs e)
        {
            await this.ListarPorMatricula();
            this.RellenarTabla();
        }

        private void RellenarTabla()
        {
            vehiculos.ForEach(v =>
            {
                tabla.Rows.Add(v.Matricula, v.Marca.Nombre, v.Modelo, v.Capacidad, v.Anio, v.CostoDia);
            });
        }

        private async Task ListarPorMatricula()
        {
            try
            {
                vehiculos = await _repositorioVehiculo.Listar();
            }
            catch (Exception)
            {

            }
        }

        private void tbMatricula_TextChanged(object sender, EventArgs e)
        {
            string matricula = tbMatricula.Text;

            int index  =  tabla.SelectedRows[0].Index;//Por defecto la seleccion actual
            bool encontrado = false;

            for(int i=0;i<tabla.Rows.Count && !encontrado;i++)
            {
                if (tabla.Rows[i].Cells[0].Value.ToString().StartsWith(matricula.ToUpper()))
                {
                    index = i;
                    encontrado = true;
                }
            }

            tabla.Rows[index].Selected = true;

        }

        private void tabla_SelectionChanged(object sender, EventArgs e)
        {
            pbFoto.Image = null;
            if (tabla.Rows.Count > 0)
            {
                string matricula = tabla.SelectedRows[0].Cells[0].Value.ToString();

                Vehiculo vehiculo = vehiculos.FirstOrDefault(v => v.Matricula == matricula);

                try
                {
                    Console.WriteLine(vehiculo.PathAbsolutoFoto);
                    pbFoto.Image = Image.FromFile(vehiculo.PathAbsolutoFoto);
                }
                catch (Exception)
                {

                }
            }
        }
    }
}
