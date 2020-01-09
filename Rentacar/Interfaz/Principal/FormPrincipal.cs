using Rentacar.Excepciones;
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
    }
}
