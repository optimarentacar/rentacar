using Rentacar.Enums;
using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioAlquiler
    {
        Task<bool> Crear(Alquiler alquiler);
        Task<List<Alquiler>> ListarPorFechaDetallado(DateTime inicio, DateTime fin, Orden orden);
        Task<List<Alquiler>> ListarPorFechaResumido(DateTime inicio, DateTime fin, Orden orden);
        Task<List<Alquiler>> Listar();
        Task<bool> AsignarAccesorios(int idAlquiler, List<int> idsAccesorio);
    }
}
