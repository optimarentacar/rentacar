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
    public partial class FormListadoClientes : Form
    {
        private IRepositorioCliente _repositorioCliente;
        private List<Cliente> Clientes;
        
        public FormListadoClientes(IRepositorioCliente repositorioCliente)
        {
            InitializeComponent();
            _repositorioCliente = repositorioCliente;
        }

        private async void FormListadoClientes_Load(object sender, EventArgs e)
        {
            await Listar();
            TotalClientes();
        }

        private async Task Listar()
        {
            try
            {
                Clientes = await _repositorioCliente.Listar();

                Tabla.Rows.Clear();
                for (int i = 0; i < Clientes.Count; i++)
                {
                    Tabla.Rows.Add(Clientes[i].Dni, Clientes[i].Nombre, Clientes[i].Telefono, Clientes[i].Domilicio);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void TotalClientes()
        {
            Total.Text = (Tabla.Rows.Count.ToString())+ " Clientes.";
        }
    }
}
