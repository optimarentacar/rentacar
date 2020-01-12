using System;
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
    public class RepositorioMarca : IRepositorioMarca
    {
        public async Task<bool> Borrar(int idMarca)
        {
            string peticion = "DELETE FROM marcas " +
                              "WHERE id = @idMarca";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idMarca", idMarca);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();

                if (result == 0)
                {
                    throw new DatosNoEncontradosException("No se ha encontrado la marca a borrar.");
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

        public async Task<bool> Crear(Marca marca)
        {
            string peticion = "INSERT INTO marcas " +
                              "VALUES (default,@nombre)";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@nombre", marca.Nombre);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();
            }
            catch (DbException ex)
            {
                if (ex.Message.Contains("UC_nombre"))
                {
                    throw new NombreMarcaYaExisteException();
                }
                else
                {
                    throw ex;
                }
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }

        public async Task<List<Marca>> Listar()
        {
            string peticion = "SELECT * FROM marcas ";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Marca> marcas = new List<Marca>();
            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Marca marca;

                    while (reader.Read())
                    {
                        marca = new Marca()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                        };
                        marcas.Add(marca);
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

            return marcas;
        }

        public async Task<bool> Modificar(Marca marca)
        {
            string peticion = "UPDATE marcas " +
                              "SET nombre = @nombre "+
                              "WHERE id = @id";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@nombre", marca.Nombre);
            command.Parameters.AddWithValue("@id", marca.Id);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();
            }
            catch (DbException ex)
            {
                if (ex.Message.Contains("UC_nombre"))
                {
                    throw new NombreMarcaYaExisteException();
                }
                else
                {
                    throw ex;
                }
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }
    }
}
