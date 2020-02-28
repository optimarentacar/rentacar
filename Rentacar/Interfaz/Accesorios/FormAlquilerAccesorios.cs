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

namespace Rentacar.Interfaz.Accesorios
{
    public partial class FormAlquilerAccesorios : Form
    {

        private readonly IRepositorioAccesorio _repositorioAccesorio;
        private List<Accesorio> Accesorios;
        private Alquiler Alquiler;

        public FormAlquilerAccesorios(IRepositorioAccesorio repositorioAccesorio)
        {
            _repositorioAccesorio = repositorioAccesorio;
            InitializeComponent();
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            int id = (int)listBoxAccesorios.SelectedValue;

            Alquiler.Accesorios.RemoveAll(c => c.Id == id);

            listBoxAccesoriosVehiculo.DataSource = null;
            listBoxAccesoriosVehiculo.Items.Clear();
            listBoxAccesoriosVehiculo.DataSource = Alquiler.Accesorios;
            listBoxAccesoriosVehiculo.DisplayMember = "Nombre";
            listBoxAccesoriosVehiculo.ValueMember = "Id";

            if (Vehiculo.Caracteristicas.Count == 0)
            {
                btnIzquierda.Enabled = false;
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {

        }
    }
}
