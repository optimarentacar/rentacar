using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioMarca
    {
        Task<bool> Crear(Marca marca);
        Task<bool> Modificar(Marca marca);
        Task<bool> Borrar(int idMarca);
    }
}
