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
        /// <summary>
        ///     Inserta un nuevo vehiculo 
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns>
        ///     Retorna true si se ha insertado
        /// </returns>
        Task<bool> Crear(Vehiculo vehiculo);

        /// <summary>
        ///     Actualiza los datos de un vehiculo 
        /// </summary>
        /// <param name="vehiculo"></param>
        /// <returns>
        ///     Retorna true si se ha actualizado
        /// </returns>
        Task<bool> Modificar(Vehiculo vehiculo);
        Task<bool> Borrar(string matricula);
        Task<Vehiculo> Obtener(string matricula);
        Task<List<Vehiculo>> Listar();
        Task<bool> AsignarCaracteristicas(string matricula, List<int> idsCaracteristica);
        Task<bool> QuitarCaracteristicas(string matricula);
        Task<List<Vehiculo>> ObtenerPorMarcaYModelo(int idMarca,string modelo);
        Task<List<Vehiculo>> ObtenerPorCaracteristica(int idCaracteristica);
        Task<List<Vehiculo>> ObtenerAlquiladosDistinct();
        Task<List<Vehiculo>> ObtenerAlquiladosGroupBy();
        Task<List<Vehiculo>> ObtenerAlquiladosPorVeces(int veces);
    }
}
