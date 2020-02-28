
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
    public partial class FormDetallesAlquiler : Form
    {
        private readonly IRepositorioVehiculo _repositorioVehiculo;
        private readonly IRepositorioCliente _repositorioCliente;
        private readonly IRepositorioAccesorio _repositorioAccesorio;
        private readonly IRepositorioCaracteristica _repositorioCaracteristica;

        public FormDetallesAlquiler(IRepositorioVehiculo repositorioVehiculo,
                                    IRepositorioCliente repositorioCliente,
                                    IRepositorioAccesorio repositorioAccesorio,
                                    IRepositorioCaracteristica repositorioCaracteristica)
        {
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioCaracteristica = repositorioCaracteristica;
            _repositorioCliente = repositorioCliente;
            _repositorioAccesorio = repositorioAccesorio;
            InitializeComponent();
        }

        


        private void FormDetallesAlquiler_Load(object sender, EventArgs e)
        {

        }

        public async Task CargarDatosAlquiler(Modelos.Alquiler alquiler)
        {
            
            try
            {
                Vehiculo v = await _repositorioVehiculo.Obtener(alquiler.Vehiculo.Matricula);

                List<Caracteristica> caracteristicas = await _repositorioCaracteristica
                    .ListarPorMatricula(alquiler.Vehiculo.Matricula);

                Cliente c = await _repositorioCliente.ObtenerPorDni(alquiler.Cliente.Dni);
                
                List<Accesorio> accesorios = await _repositorioAccesorio
                    .ListarPorAlquiler(alquiler.Id);
                Console.WriteLine("AA");
                textMatricula.Text =v.Matricula;
                textMarca.Text = v.Marca.Nombre;
                textModelo.Text = v.Modelo;
                textAnyo.Text = v.Anio;
                textPlazas.Text = v.Capacidad.ToString();

                pictureBoxFoto.Image = Image.FromFile(v.PathAbsolutoFoto);

                textDni.Text = c.Dni;
                textNombre.Text = c.Nombre;
                textDomicilio.Text = c.Domilicio;
                textTelefono.Text = c.Telefono;

                textFechaInicio.Text = alquiler.FechaInicio.ToString("dd/MM/yyyy");
                textFechaFin.Text = alquiler.FechaFin.ToString("dd/MM/yyyy");
                textTotal.Text = alquiler.Importe.ToString();

                int dias = (alquiler.FechaFin - alquiler.FechaInicio).Days;
                labelDias.Text = "Importe(" + dias + " días.)";
                float importeAccesorios = alquiler.CostoTotalAccesorios;
                textImporteAccesorios.Text = importeAccesorios.ToString();

                textImporte.Text = (alquiler.Importe - importeAccesorios).ToString();

                listBoxAccesorios.DataSource = accesorios;
                listBoxAccesorios.DisplayMember = "Nombre";
                listBoxAccesorios.ValueMember = "Id";

                listBoxCaracteristicas.DataSource = caracteristicas;
                listBoxCaracteristicas.DisplayMember = "Nombre";
                listBoxCaracteristicas.ValueMember = "Id";


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error.");
            }
            
        }

        private void btnCaracteristicas_Click(object sender, EventArgs e)
        {
            pictureBoxFoto.Visible = false;
            listBoxCaracteristicas.Visible = true;
        }


        private void btnFoto_Click(object sender, EventArgs e)
        {
            pictureBoxFoto.Visible = true;
            listBoxCaracteristicas.Visible = false;
        }
    }
}
