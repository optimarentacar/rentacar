using Rentacar.Interfaz.Accesorios;
using Rentacar.Interfaz.Factura;
using Rentacar.Interfaz.Operaciones.Vehiculos;
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

namespace Rentacar.Interfaz.Operaciones.Alquiler
{
    public partial class FormAlquilerVehiculos : Form
    {
        private readonly IRepositorioAlquiler _repositorioAlquiler;
        private List<Modelos.Alquiler> Alquileres;
        private Modelos.Alquiler Alquiler;
        private IRepositorioVehiculo _repositorioVehiculo;
        private IRepositorioCliente _repositorioCliente;
        private IRepositorioCaracteristica _repositorioCaracteristica;
        private IRepositorioAccesorio _repositorioAccesorio;

        public FormAlquilerVehiculos(IRepositorioAlquiler repositorioAlquiler, IRepositorioVehiculo repositorioVehiculo, IRepositorioCliente repositorioCliente, IRepositorioCaracteristica repositorioCaracteristica, IRepositorioAccesorio repositorioAccesorio)
        {
            _repositorioAlquiler = repositorioAlquiler;
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioCliente = repositorioCliente;
            _repositorioCaracteristica = repositorioCaracteristica;
            _repositorioAccesorio = repositorioAccesorio;
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
                        Alquileres[i].Importe, Alquileres[i].CostoTotalAccesorios);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error");
            }
        }

        private async void btnVerDetalles_Click(object sender, EventArgs e)
        {
            FormDetallesAlquiler fda = Program.container.GetInstance<FormDetallesAlquiler>();
            await fda.CargarDatosAlquiler(Alquiler);
            fda.ShowDialog();
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (Tabla.SelectedRows.Count > 0)
            {
                int id = (int)Tabla.SelectedRows[0].Cells[0].Value;

                Alquiler = Alquileres.FirstOrDefault(a => a.Id == id);
            }
        }


        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Deseas cancelar el " +
                "alquiler del vehículo?", "Confirmación",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                bool borrado = false;
                try
                {
                    borrado = await _repositorioAlquiler.Borrar(Alquiler.Id);
                    await Listar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocurrió un error");
                }
            }
        }

        private async void btnAccesorios_Click(object sender, EventArgs e)
        {
            FormAlquilerAccesorios faa = Program.container.GetInstance<FormAlquilerAccesorios>();
            await faa.ListarAccesoriosAlquiler(Alquiler.Id);
            faa.ShowDialog();

            if (faa.Cerrado)
            {
                await Listar();
            }

        }
        private async void btnAlquilar_Click(object sender, EventArgs e)
        {
            FormVehiculosAlquiler gm = Program.container.GetInstance<FormVehiculosAlquiler>();
            gm.ShowDialog();
            await Listar();


        }

        private async void btnImprimir_Click(object sender, EventArgs e)
        {
            await cargarDatosAlquiler();
            FormFactura gm = Program.container.GetInstance<FormFactura>();
            gm.rellenarDatos(Alquiler);
        }

        private async Task cargarDatosAlquiler()
        {
            try
            {
                Cliente c = await _repositorioCliente.ObtenerPorDni(Alquiler.Cliente.Dni);
                Vehiculo v = await _repositorioVehiculo.Obtener(Alquiler.Vehiculo.Matricula);
                Alquiler.Vehiculo = v;
                Alquiler.Cliente = c;

                List<Caracteristica> caracteristicas = await _repositorioCaracteristica.ListarPorMatricula(Alquiler.Vehiculo.Matricula);
                Alquiler.Vehiculo.Caracteristicas = caracteristicas;
                List<Accesorio> accesorios = await _repositorioAccesorio.ListarPorAlquiler(Alquiler.Id);
                Alquiler.Accesorios = accesorios;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
