using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rentacar.Enums;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioAlquiler : IRepositorioAlquiler
    {
        public Task<bool> AsignarAccesorios(int idAlquiler, List<int> idsAccesorio)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Crear(Alquiler alquiler)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alquiler>> Listar()
        {
            throw new NotImplementedException();
        }

        public Task<List<Alquiler>> ListarPorFechaDetallado(DateTime inicio, DateTime fin, Orden orden)
        {
            throw new NotImplementedException();
        }

        public Task<List<Alquiler>> ListarPorFechaResumido(DateTime inicio, DateTime fin, Orden orden)
        {
            throw new NotImplementedException();
        }
    }
}
