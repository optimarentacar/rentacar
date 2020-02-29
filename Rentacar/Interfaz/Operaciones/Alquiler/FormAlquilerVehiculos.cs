using Rentacar.Interfaz.Operaciones.Vehiculos;
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

namespace Rentacar.Interfaz.Operaciones.Alquiler
{
    public partial class FormAlquilerVehiculos : Form
    {
        private readonly IRepositorioAlquiler _repositorioAlquiler;
        private List<Modelos.Alquiler> Alquileres;
        private Modelos.Alquiler Alquiler;

        public FormAlquilerVehiculos(IRepositorioAlquiler repositorioAlquiler)
        {
            _repositorioAlquiler = repositorioAlquiler;
            InitializeComponent();
        }

        private async void FormAlquilerVehiculos_Load(object sender, EventArgs e)
        {
            await Listar();
        }

        private async Task Listar()
        {
            try
            {
                Alquileres = await _repositorioAlquiler.Listar();

                Tabla.Rows.Clear();
                for (int i = 0; i < Alquileres.Count; i++)
                {
                    Tabla.Rows.Add(Alquileres[i].Id, Alquileres[i].Vehiculo.Matricula,
                        Alquileres[i].Cliente.Dni, Alquileres[i].FechaInicio.ToString("dd/MM/yyyy")
                        , Alquileres[i].FechaFin.ToString("dd/MM/yyyy"),
                        Alquileres[i].Importe,Alquileres[i].CostoTotalAccesorios);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private async void btnVerDetalles_Click(object sender, EventArgs e)
        {
            FormDetallesAlquiler fda = Program.container.GetInstance<FormDetallesAlquiler>();
            await fda.CargarDatosAlquiler(Alquiler);
            fda.Show();
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count > 0)
            {
                int id =(int) Tabla.SelectedRows[0].Cells[0].Value;

                Alquiler = Alquileres.FirstOrDefault(a => a.Id == id);
            }
        }

        private void btnAlquilar_Click(object sender, EventArgs e)
        {
            FormVehiculosAlquiler gm = Program.container.GetInstance<FormVehiculosAlquiler>();
            gm.ShowDialog();

        }
    }
}
