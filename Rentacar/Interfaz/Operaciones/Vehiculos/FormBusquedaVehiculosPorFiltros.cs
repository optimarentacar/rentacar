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
    public partial class FormBusquedaVehiculosPorFiltros : Form
    {
        private readonly IRepositorioMarca _repositorioMarca;
        private readonly IRepositorioVehiculo _repositorioVehiculo;
        private readonly IRepositorioCaracteristica _repositorioCaracteristica;
        private List<Marca> marcas;
        private List<string> modelos;
        private List<Vehiculo> vehiculos;
        private List<Caracteristica> caracteristicas;

        public FormBusquedaVehiculosPorFiltros(IRepositorioMarca repositorioMarca,
                                               IRepositorioVehiculo repositorioVehiculo,
                                               IRepositorioCaracteristica repositorioCaracteristica)
        {
            _repositorioMarca = repositorioMarca;
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioCaracteristica = repositorioCaracteristica;
            InitializeComponent();
        }

        private async void FormBusquedaVehiculosPorFiltros_Load(object sender, EventArgs e)
        {
            await this.ListarMarcas();
            await this.ListarCaracteristicas();
            this.RellenarComboBoxMarcas();
            this.RellenarComboBoxCaracteristicas();
        }

        private void RellenarComboBoxMarcas()
        {
            if (this.marcas != null)
            {
                cbMarcas.DataSource = this.marcas;
                cbMarcas.ValueMember = "Id";
                cbMarcas.DisplayMember = "Nombre";
            }
        }

        private void RellenarComboBoxCaracteristicas()
        {
            if (this.caracteristicas != null)
            {
                cbCaracteristicas.DataSource = this.caracteristicas;
                cbCaracteristicas.ValueMember = "Id";
                cbCaracteristicas.DisplayMember = "Nombre";
            }
        }

        private void RellenarComboBoxModelos()
        {
            if (this.marcas != null)
            {
                cbModelos.DataSource = this.modelos;
            }
        }

        private async Task ListarMarcas()
        {
            try
            {
                this.marcas = await _repositorioMarca.Listar();
            }
            catch (Exception)
            {

            }
        }

        private async Task ListarCaracteristicas()
        {
            try
            {
                this.caracteristicas = await _repositorioCaracteristica.Listar();
            }
            catch (Exception)
            {

            }
        }

        private async Task ListarModelosPorMarca(int idMarca)
        {
            try
            {
                this.modelos = await _repositorioVehiculo.ObtenerModelosPorMarca(idMarca);
            }
            catch (Exception)
            {

            }
        }

        private void BloquearFiltros()
        {
            checkboxMarca.Checked = false;
            checkBoxModelo.Checked = false;
            checkBoxModelo.Enabled = false;
            cbModelos.Enabled = false;
            cbMarcas.Enabled = false;
            btnAplicarFiltro.Enabled = false;
        }

        private async void cbMarca_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxMarca.Checked)
            {
                if (this.marcas != null)
                {
                    int id = (int)cbMarcas.SelectedValue;
                    await this.ListarModelosPorMarca(id);
                    this.RellenarComboBoxModelos();
                    cbMarcas.Enabled = true;
                    checkBoxModelo.Enabled = true;
                    btnAplicarFiltro.Enabled = true;
                }
            }
            else
            {
                this.BloquearFiltros();
            }
        }

        private void cbModelo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxModelo.Checked)
            {
                cbModelos.Enabled = true;
            }
            else
            {
                cbModelos.Enabled = false;
            }
        }

        private async void cbMarcas_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbMarcas.Items.Count > 0)
            {
                int id = (int)cbMarcas.SelectedValue;
                await this.ListarModelosPorMarca(id);
                this.RellenarComboBoxModelos();
            }
        }

        private async void btnAplicarFiltro_Click(object sender, EventArgs e)
        {
            if(checkboxMarca.Checked && checkBoxModelo.Checked && cbModelos.Items.Count>0)
            {
                await this.ListarVehiculosPorMarcaYModelo();
            }
            else if (checkboxMarca.Checked && !checkBoxModelo.Checked )
            {
                await this.ListarVehiculosPorMarca();

            }

            this.RellenarTabla();
        }

        private async Task ListarVehiculosPorMarca()
        {
            int id = (int)cbMarcas.SelectedValue;

            try
            {
                this.vehiculos = await _repositorioVehiculo.ObtenerPorMarca(id);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task ListarVehiculosPorMarcaYModelo()
        {
            int id = (int)cbMarcas.SelectedValue;
            string modelo = cbModelos.SelectedItem.ToString();
            try
            {
                this.vehiculos = await _repositorioVehiculo.ObtenerPorMarcaYModelo(id,modelo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task ListarVehiculosPorCaracteristica()
        {
            int id = (int)cbCaracteristicas.SelectedValue;
 
            try
            {
                this.vehiculos = await _repositorioVehiculo.ObtenerPorCaracteristica(id);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task ListarVehiculosParecidosAMarcaYModelo()
        {
            string marca = tbMarca.Text;
            string modelo = tbModelo.Text;

            try
            {
                this.vehiculos = await _repositorioVehiculo
                    .ObtenerParecidosAMarcaYModelo(marca,modelo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task ListarVehiculosAlquiladosDistinct()
        {

            try
            {
                this.vehiculos = await _repositorioVehiculo
                    .ObtenerAlquiladosDistinct();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task ListarVehiculosAlquiladosGroupBy()
        {

            try
            {
                this.vehiculos = await _repositorioVehiculo
                    .ObtenerAlquiladosGroupBy();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async Task ListarVehiculosAlquiladosPorVeces()
        {
            try
            {
                int veces = int.Parse(tbVeces.Text);

                try
                {
                   
                    this.vehiculos = await _repositorioVehiculo
                        .ObtenerAlquiladosPorVeces(veces);

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("La cantidad de veces introducida no es correcta", "Error");
            }
            
            
        }

        private void RellenarTabla()
        {
            tabla.Rows.Clear();

            if (this.vehiculos != null)
            {
                vehiculos.ForEach(v =>
                {
                    tabla.Rows.Add(v.Matricula, v.Marca.Nombre,
                        v.Modelo, v.Capacidad, v.Anio, v.CostoDia);
                });
            }
        }

        private void TodosLosRadioBox_OnCLick(object sender, EventArgs e)
        {
            this.BloquearFiltros();
            this.btnBuscar.Enabled = true;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rbMarcaModelo.Checked)
            {
                await this.ListarVehiculosParecidosAMarcaYModelo();
            }
            if (rbCaracteristicas.Checked)
            {
                await this.ListarVehiculosPorCaracteristica();
            }
            if (rbAlquiladosVeces.Checked)
            {
                await this.ListarVehiculosAlquiladosPorVeces();
            }
            if (rbAlquiladosGroupBy.Checked)
            {
                await this.ListarVehiculosAlquiladosGroupBy();
            }
            if (rbAlquiladoDistinct.Checked)
            {
                await this.ListarVehiculosAlquiladosDistinct();
            }

            this.RellenarTabla();
        }
    }
}
