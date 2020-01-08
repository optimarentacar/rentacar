using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioCaracteristica
    {
        bool Crear(Caracteristica caracteristica);
        bool Modificar(Caracteristica caracteristica);
        bool Borrar(int idCaracteristica);
    }
}
