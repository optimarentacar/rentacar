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
            
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {

        }
    }
}
