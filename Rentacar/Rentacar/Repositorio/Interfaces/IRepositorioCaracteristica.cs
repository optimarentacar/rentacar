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
        Task<bool> Crear(Caracteristica caracteristica);
        Task<bool> Modificar(Caracteristica caracteristica);
        Task<bool> Borrar(int idCaracteristica);
    }
}
