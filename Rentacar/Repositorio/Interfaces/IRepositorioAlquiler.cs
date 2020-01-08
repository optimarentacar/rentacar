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
        bool Crear(Alquiler alquiler);
        List<Alquiler> ListarPorFechaDetallado(DateTime inicio, DateTime fin, Orden orden);
        List<Alquiler> ListarPorFechaResumido(DateTime inicio, DateTime fin, Orden orden);
        List<Alquiler> Listar();
        bool AsignarAccesorios(int idAlquiler, List<int> idsAccesorio);
    }
}
