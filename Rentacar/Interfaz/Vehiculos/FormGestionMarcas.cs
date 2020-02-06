
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

namespace Rentacar.Interfaz.Vehiculos
{
    public partial class FormGestionMarcas : Form
    {
        private IRepositorioMarca _repositorioMarca;
        private List<Marca> Marca;

        public FormGestionMarcas(IRepositorioMarca repositorioMarca)
        {
            InitializeComponent();
            _repositorioMarca = repositorioMarca;
        }

        private async void FormGestionMarcas_Load(object sender, EventArgs e)
        {
            await Listar();
        }
        private async Task Listar()
        {
            try
            {
                Marca = await _repositorioMarca.Listar();

                Tabla.Rows.Clear();
                for (int i = 0; i < Marca.Count; i++)
                {
                    Tabla.Rows.Add(Marca[i].Id, Marca[i].Nombre);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
