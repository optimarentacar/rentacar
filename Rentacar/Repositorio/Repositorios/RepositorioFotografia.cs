using Rentacar.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioFotografia : IRepositorioFotografia
    {

        public string Guardar(Image fotografia)
        {
            Guid g = Guid.NewGuid();
            string nombreImagen = g + ".jpg";
            string rutaRelativa = "\\Recursos\\Fotografias\\" + nombreImagen;
            string ruta = Application.StartupPath + rutaRelativa;

            if (!Directory.Exists(Application.StartupPath + "\\Recursos\\Fotografias"))
            {
                Directory.CreateDirectory(Application.StartupPath + "\\Recursos\\Fotografias");

            }

            fotografia.Save(ruta, ImageFormat.Jpeg);

            return rutaRelativa;

        }

        public void Borrar(string rutaRelativa)
        {
            if (File.Exists(Application.StartupPath + rutaRelativa))
            {
     
                File.Delete(Application.StartupPath + rutaRelativa);
            }
        }

        public void BorrarAntiguaFoto (string rutaAbsoluta)
        {
            if (File.Exists(rutaAbsoluta))
            {
                Console.WriteLine("AAAAAAAAAAAAAAAAAAAAAAAAA"+ rutaAbsoluta);
                File.Delete(rutaAbsoluta);
            }
        }
    }
}
