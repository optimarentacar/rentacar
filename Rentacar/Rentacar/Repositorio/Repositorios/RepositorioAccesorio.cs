using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioAccesorio : IRepositorioAccesorio
    {
        public Task<bool> Borrar(int idAccesorio)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Crear(Accesorio accesorio)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modificar(Accesorio accesorio)
        {
            throw new NotImplementedException();
        }
    }
}
