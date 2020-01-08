using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        public bool AsignarCaracteristicas(string matricula, List<int> idsCaracteristica)
        {
            throw new NotImplementedException();
        }

        public bool Borrar(string matricula)
        {
            throw new NotImplementedException();
        }

        public bool Crear(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> Listar()
        {
            Console.WriteLine("AAAAAAAAAAAAAAAA");
            return null;
        }

        public bool Modificar(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public Vehiculo Obtener(string matricula)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> ObtenerAlquiladosDistinct()
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> ObtenerAlquiladosGroupBy()
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> ObtenerAlquiladosPorVeces(int veces)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> ObtenerPorCaracteristica(int idCaracteristica)
        {
            throw new NotImplementedException();
        }

        public List<Vehiculo> ObtenerPorMarcaYModelo(int idMarca, string modelo)
        {
            throw new NotImplementedException();
        }

        public bool QuitarCaracteristicas(string matricula)
        {
            throw new NotImplementedException();
        }
    }
}
