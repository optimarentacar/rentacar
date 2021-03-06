﻿using Rentacar.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Interfaces
{
    public interface IRepositorioCliente
    {
        /// <summary>
        ///     Guarda un cliente en la base de datos.
        /// </summary>
        /// <exception cref="DniYaExisteException">
        /// </exception>
        /// <param name="cliente"></param>
        /// <returns>
        /// </returns>
        Task<bool> Crear(Cliente cliente);

        /// <summary>
        ///     Actualiza un cliente en la base de datos.
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>
        /// </returns>
        Task<bool> Modificar(Cliente cliente);

        /// <summary>
        ///     Borra un cliente en la base de datos.
        /// </summary>
        /// <exception cref="DatosNoEncontradosException">
        /// </exception>
        /// <param name="dni"></param>
        /// <returns>
        /// </returns>
        Task<bool> Borrar(string dni);

        /// <summary>
        ///     Obtiene el cliente de la base de datos 
        ///     con el dni pasado por parametros.
        /// </summary>
        /// <exception cref="DatosNoEncontradosException">
        /// </exception>
        /// <param name="dni"></param>
        /// <returns>
        /// </returns>
        Task<Cliente> ObtenerPorDni(string dni);

        /// <summary>
        ///     Obtiene la lista de clientes de la base de datos 
        ///     con el nombre pasado por parametros.
        /// </summary>
        /// <exception cref="DatosNoEncontradosException">
        /// </exception>
        /// <param name="dni"></param>
        /// <returns>
        /// </returns>
        Task<List<Cliente>> ObtenerPorNombre(string nombre);

        /// <summary>
        ///     Obtiene la lista de clientes 
        ///     de la base de datos.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<List<Cliente>> Listar();

        /// <summary>
        ///     Obtiene la lista de clientes 
        ///     cuyo nombre empieza por la cadena
        ///     pasada por parámetro.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<List<Cliente>> ObtenerParecidosANombre(string nombre);

        /// <summary>
        ///     Obtiene la lista de clientes 
        ///     cuyo dni empieza por la cadena
        ///     pasada por parámetro.
        /// </summary>
        /// <returns>
        /// </returns>
        Task<List<Cliente>> ObtenerParecidosADni(string dni);

        /// <summary>
        ///     Comprueba si el cliente tiene
        ///     alquileres asignados o no
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        Task<bool> TieneAlquileresAsignados(string dni);
    }
}
