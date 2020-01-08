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
        bool Crear(Marca marca);
        bool Modificar(Marca marca);
        bool Borrar(int idMarca);
    }
}
