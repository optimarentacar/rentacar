using Rentacar.Excepciones;
using Rentacar.Interfaz.Clientes;
using Rentacar.Interfaz.Vehiculos;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Principal
{
    public partial class FormPrincipal : Form
    {
        private IRepositorioVehiculo _repositorioVehiculo;
        private IRepositorioCliente _repositorioCliente;

        public FormPrincipal(IRepositorioVehiculo repositorioVehiculo,IRepositorioCliente repositorioCliente)
        {
            _repositorioVehiculo = repositorioVehiculo;
            _repositorioCliente = repositorioCliente;
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {

                await _repositorioCliente.Crear(new Cliente()
                {
                    Dni = "12345678A",
                    Nombre = "Pepe",
                    Domilicio = "Calle",
                    Telefono = "123654789"
                });
            }
            catch(DniYaExisteException dyee)
            {
                MessageBox.Show(dyee.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionCliente fgc = Program.container.GetInstance<FormGestionCliente>();
            fgc.ShowDialog();
        }

        private void vehículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGestionVehiculos fgv = Program.container.GetInstance<FormGestionVehiculos>();
            fgv.ShowDialog();
        }
    }
}
