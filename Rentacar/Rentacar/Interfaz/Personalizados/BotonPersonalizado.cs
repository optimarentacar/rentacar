using Rentacar.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Personalizados
{
    public class BotonPersonalizado : Button
    {
        public BotonPersonalizado()
        {
            this.BackColor = Settings.Default.colorPrincipal;
        }
    }
}
