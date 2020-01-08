using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioAccesorio
    {
        bool Crear(Accesorio accesorio);
        bool Modificar(Accesorio accesorio);
        bool Borrar(int idAccesorio);
    }
}
