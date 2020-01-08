using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioCliente
    {
        bool Crear(Cliente cliente);
        bool Modificar(Cliente cliente);
        bool Borrar(int idCliente);
        Cliente Obtener(int idCliente);
        List<Cliente> Listar();
    }
}
