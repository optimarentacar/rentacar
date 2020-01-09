using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioCaracteristica : IRepositorioCaracteristica
    {
        public Task<bool> Borrar(int idCaracteristica)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Crear(Caracteristica caracteristica)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Modificar(Caracteristica caracteristica)
        {
            throw new NotImplementedException();
        }
    }
}
