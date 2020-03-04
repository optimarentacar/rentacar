using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rentacar.Modelos;

namespace Rentacar.Interfaz.Informes
{
    public partial class ControlListadoCaracteristicas : UserControl
    {
        public ControlListadoCaracteristicas(Caracteristica caracteristica)
        {
            InitializeComponent();
            rellenarDatos(caracteristica);
        }

        private void rellenarDatos(Caracteristica caracteristica)
        {
            lbCaracteristicas.Text = caracteristica.Nombre;
        }
    }
}
