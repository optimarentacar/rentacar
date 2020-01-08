using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using Rentacar.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Servicios.Servicios
{
    public class ServicioVehiculo : IServicioVehiculo
    {
        private readonly IRepositorioVehiculo _repositorioVehiculo;

        public ServicioVehiculo(IRepositorioVehiculo repositorioVehiculo)
        {
            _repositorioVehiculo = repositorioVehiculo;
        }

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
            return _repositorioVehiculo.Listar();
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
    }
}
