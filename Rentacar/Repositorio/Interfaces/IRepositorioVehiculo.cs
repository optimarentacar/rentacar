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
        ///     Guarda un nuevo vehiculo 
        /// </summary>
        /// <exception cref="MatriculaYaExisteException">
        /// </exception>
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

        /// <summary>
        ///     Borra un vehiculo
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        Task<bool> Borrar(string matricula);

        /// <summary>
        ///     Obtiene un vehiculo dada su matricula
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        Task<Vehiculo> Obtener(string matricula);

        /// <summary>
        ///     Obtiene la lista de todos los vehiculos
        /// </summary>
        /// <returns></returns>
        Task<List<Vehiculo>> Listar();

       
        /// <summary>
        ///     Obtiene la lista de vehiculos dados
        ///     una marca y modelo
        /// </summary>
        /// <param name="idMarca"></param>
        /// <param name="modelo"></param>
        /// <returns></returns>
        Task<List<Vehiculo>> ObtenerPorMarcaYModelo(int idMarca,string modelo);

        /// <summary>
        ///     Obtiene la lista de vehiculos dada
        ///     una marca 
        /// </summary>
        /// <param name="idMarca"></param>
        /// <returns></returns>
        Task<List<Vehiculo>> ObtenerPorMarca(int idMarca);

        /// <summary>
        ///     Obtiene la lista de vehiculos cuyo nombres
        ///     de la marca y del modelo
        ///     empiezen por las cadenas pasadas 
        ///     por parametro
        /// </summary>
        /// <param name="idMarca"></param>
        /// <param name="modelo"></param>
        /// <returns></returns>
        Task<List<Vehiculo>> ObtenerParecidosAMarcaYModelo(string marca, string modelo);
       
        /// <summary>
        ///     Obtiene la lista de vehiculos dada
        ///     una característica
        /// </summary>
        /// <param name="idCaracteristica"></param>
        /// <returns></returns>
        Task<List<Vehiculo>> ObtenerPorCaracteristica(int idCaracteristica);

        /// <summary>
        ///     Obtiene la lista de vehículos alquilados
        ///     al menos una vez usando DISTINCT    
        /// </summary>
        /// <returns></returns>
        Task<List<Vehiculo>> ObtenerAlquiladosDistinct();

        /// <summary>
        ///     Obtiene la lista de vehículos alquilados
        ///     al menos una vez usando GROUP BY    
        /// </summary>
        /// <returns></returns>
        Task<List<Vehiculo>> ObtenerAlquiladosGroupBy();

        /// <summary>
        ///     Obtiene la lista de vehículos alquilados
        ///     la cantidad de veces pasada por parametro    
        /// </summary>
        /// <returns></returns>
        Task<List<Vehiculo>> ObtenerAlquiladosPorVeces(int veces);

        /// <summary>
        ///     Obtiene la lista de todos los modelos
        ///     de vehículos dada una marca
        /// </summary>
        /// <param name="idMarca"></param>
        /// <returns></returns>
        Task<List<string>> ObtenerModelosPorMarca(int idMarca);

        /// <summary>
        ///     Comprueba si un vehiculo tiene alquileres
        ///     asignados
        /// </summary>
        /// <param name="matricula"></param>
        /// <returns></returns>
        Task<bool> TieneAlquileresAsignados(string matricula);

        Task<List<Vehiculo>> ListarDisponibles(DateTime inicio,DateTime fin);


    }
}
