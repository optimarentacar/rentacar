using Rentacar.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Interfaz.Personalizados
{
    public class LabelPersonalizado : Label
    {
        public LabelPersonalizado()
        {
            this.Font = Settings.Default.Fuente;
        }
    }
}
