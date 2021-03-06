﻿using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Rentacar.Excepciones;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioCaracteristica : IRepositorioCaracteristica
    {
        public async Task<bool> Borrar(int idCaracteristica)
        {
            string peticion = 
                "DELETE FROM caracteristicas " +
                "WHERE id = @idCaracteristica";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idCaracteristica", idCaracteristica);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();

                if (result == 0)
                {
                    throw new DatosNoEncontradosException("No se ha encontrado la característica a borrar.");
                }
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }

        public async Task<bool> Crear(Caracteristica caracteristica)
        {
            string peticion =
                "INSERT INTO caracteristicas " +
                "VALUES (default, @nombre)";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@nombre", caracteristica.Nombre);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }

        public async Task<List<Caracteristica>> Listar()
        {
            string peticion =
               "SELECT * FROM caracteristicas " +
               "ORDER BY nombre";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Caracteristica> caracteristicas = new List<Caracteristica>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Caracteristica caracteristica;

                    while (reader.Read())
                    {
                        caracteristica = new Caracteristica()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };
                        caracteristicas.Add(caracteristica);
                    }
                }
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return caracteristicas;
        }

        public async Task<List<Caracteristica>> ListarPorMatricula(string matricula)
        {
            string peticion =
               "SELECT * FROM caracteristicas c " +
               "INNER JOIN caracteristicas_vehiculos cv " + 
               "ON c.id = cv.idCaracteristica " +
               "INNER JOIN vehiculos v " + 
               "ON cv.matricula = v.matricula " +
               "AND v.matricula = @matricula " +
               "ORDER BY nombre";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", matricula);
            command.Prepare();

            List<Caracteristica> caracteristicas = new List<Caracteristica>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Caracteristica caracteristica;

                    while (reader.Read())
                    {
                        caracteristica = new Caracteristica()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1)
                        };
                        caracteristicas.Add(caracteristica);
                    }
                }
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return caracteristicas;
        }

        public async Task<bool> Modificar(Caracteristica caracteristica)
        {
            string peticion =
                "UPDATE caracteristicas " +
                "SET nombre = @nombre " +
                "WHERE id = @id";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@nombre", caracteristica.Nombre);
            command.Parameters.AddWithValue("@id", caracteristica.Id);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();

                if (result == 0)
                {
                    throw new DatosNoEncontradosException("No se ha encontrado la característica a actualizar.");
                }
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }

        public async Task<bool> TieneAlquileresAsignados(int idCaracteristica)
        {
            string peticion =
                "SELECT ca.id FROM caracteristicas ca " +
                "INNER JOIN caracteristicas_vehiculos cv " +
                    "ON ca.id = cv.idCaracteristica " +
                    "AND ca.id = @idCaracteristica " +
                "INNER JOIN vehiculos v " +
                    "ON cv.matricula = v.matricula " +
                "INNER JOIN alquileres al " +
                    "ON v.matricula = al.matricula " +
                "LIMIT 1";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idCaracteristica", idCaracteristica);
            command.Prepare();

            bool resultado = false;

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    resultado = true;
                }
            }
            catch (DbException ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return resultado;
        }
    }
}
