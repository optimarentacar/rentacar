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
        Task<bool> Crear(Accesorio accesorio);
        Task<bool> Modificar(Accesorio accesorio);
        Task<bool> Borrar(int idAccesorio);
        Task<List<Accesorio>> Listar();
        Task<bool> TieneAlquileresAsignados(int idAccesorio);
    }
}
