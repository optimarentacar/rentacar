using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioFotografia
    {
        string Guardar(Image fotografia);

        void Borrar(string pathFoto);

        void BorrarAntiguaFoto(string rutaAbsoluta);


    }
}
