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
    public partial class FormVehiculosAlquiler : Form
    {
        private IRepositorioCliente _repositorioCliente;
        private IRepositorioVehiculo _repositorioVehiculo;
        private IRepositorioAlquiler _repositorioAlquiler;
        private List<Cliente> Cliente;
        private List<Vehiculo> Vehiculos;
        private List<Modelos.Alquiler> Alquiler;
        private DateTime inicio;
        private DateTime final;

        public FormVehiculosAlquiler(IRepositorioCliente repositorioCliente, IRepositorioVehiculo repositorioVehiculo, IRepositorioAlquiler repositorioAlquiler)
        {
            InitializeComponent();
            _repositorioCliente = repositorioCliente;
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioAlquiler = repositorioAlquiler;
        }
        private async void FormVehiculosAlquiler_Load(object sender, EventArgs e)
        {
            await listarCliente();
        }

        private async Task listarCliente()
        {
            try
            {
                Cliente = await _repositorioCliente.Listar();
                comboBoxCliente.DataSource = Cliente;
                comboBoxCliente.DisplayMember ="Nombre";
                comboBoxCliente.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task listarVehiculo()
        {
            try
            {//Cambiar listar
                Vehiculos = await _repositorioVehiculo.ListarDisponibles(inicio,final);
                comboBoxVehiculo.DataSource = Vehiculos;
                comboBoxVehiculo.DisplayMember = "Matricula";
                comboBoxVehiculo.ValueMember = "Id";

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            inicio = monthCalendar1.SelectionRange.Start.Date;
            final = monthCalendar1.SelectionRange.End.Date;

            int dias = (final - inicio).Days;
            await listarVehiculo();
            float total = dias * ((comboBoxVehiculo.SelectedItem as Vehiculo).CostoDia);
            textPrecioDia.Text = ((comboBoxVehiculo.SelectedItem as Vehiculo).CostoDia).ToString();
            textDias.Text = dias.ToString();
            textTotal.Text = total.ToString();
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnAceptar_Click(object sender, EventArgs e)
        {
            Modelos.Alquiler alquiler = new Modelos.Alquiler()
            {
                Cliente = new Cliente()
                {
                    Dni = (comboBoxCliente.SelectedItem as Cliente).Dni
                },
                FechaInicio = inicio,
                FechaFin = final,
                Importe = float.Parse(textTotal.Text),
                Vehiculo = new Vehiculo()
                {
                    Matricula = (comboBoxVehiculo.SelectedItem as Vehiculo).Matricula
                }
            };

            bool creado;
            try
            {
                creado = await _repositorioAlquiler.Crear(alquiler);
                if(creado == true)
                {
                    MessageBox.Show("Alquier Creado");                  
                }
                limpiar();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
            }          
        }

        private void limpiar()
        {
            monthCalendar1.SetDate(DateTime.Now);
            comboBoxVehiculo.DataSource = null;
            textDias.Text = "";
            textPrecioDia.Text = "";
            textTotal.Text = "";
        }
    }
}
