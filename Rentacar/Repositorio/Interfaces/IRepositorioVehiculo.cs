using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioVehiculo
    {
        bool Crear(Vehiculo vehiculo);
        bool Modificar(Vehiculo vehiculo);
        bool Borrar(string matricula);
        Vehiculo Obtener(string matricula);
        List<Vehiculo> Listar();
        bool AsignarCaracteristicas(string matricula, List<int> idsCaracteristica);
        bool QuitarCaracteristicas(string matricula);
        List<Vehiculo> ObtenerPorMarcaYModelo(int idMarca,string modelo);
        List<Vehiculo> ObtenerPorCaracteristica(int idCaracteristica);
        List<Vehiculo> ObtenerAlquiladosDistinct();
        List<Vehiculo> ObtenerAlquiladosGroupBy();
        List<Vehiculo> ObtenerAlquiladosPorVeces(int veces);
    }
}
