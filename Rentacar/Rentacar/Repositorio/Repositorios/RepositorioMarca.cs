using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioMarca : IRepositorioMarca
    {
        public Task<bool> Borrar(int idMarca)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Crear(Marca marca)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modificar(Marca marca)
        {
            throw new NotImplementedException();
        }
    }
}
