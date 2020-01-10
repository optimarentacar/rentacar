using MySql.Data.MySqlClient;
using Rentacar.Excepciones;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioCliente : IRepositorioCliente
    {

        public async Task<bool> Borrar(string dni)
        {
            string peticion = "DELETE FROM clientes " +
                              "WHERE dni = @dni";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@dni", dni);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();

                if (result == 0)
                {
                    throw new DatosNoEncontradosException("No se ha encontrado el cliente a borrar.");
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

        public async Task<bool> Crear(Cliente cliente)
        {
            string peticion = "INSERT INTO clientes " +
                              "VALUES (@dni,@nombre,@telefono,@domicilio)";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@dni", cliente.Dni);
            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@telefono", cliente.Telefono);
            command.Parameters.AddWithValue("@domicilio", cliente.Domilicio);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();
            }
            catch (DbException ex)
            {
                if (ex.Message.Contains("Duplicate entry"))
                {
                    throw new DniYaExisteException();
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

        public async Task<bool> Modificar(Cliente cliente)
        {
            string peticion = "UPDATE clientes " +
                              "SET nombre = @nombre, telefono = @telefono, " +
                                   "domicilio = @domicilio" +
                              "WHERE dni = @dni";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@nombre", cliente.Nombre);
            command.Parameters.AddWithValue("@telefono", cliente.Telefono);
            command.Parameters.AddWithValue("@domicilio", cliente.Domilicio);
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

        public async Task<Cliente> Obtener(string dni)
        {
            string peticion = "SELECT * FROM clientes " +
                              "WHERE dni = @dni";
            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);

            Cliente cliente = null;

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    cliente = new Cliente()
                    {
                        Dni = reader.GetString(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2),
                        Domilicio = reader.GetString(3),
                    };
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

            return cliente;
        }

        public async Task<List<Cliente>> Listar()
        {
            string peticion = "SELECT * FROM clientes";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Cliente> clientes = new List<Cliente>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Cliente cliente;

                    while (reader.Read())
                    {
                        cliente = new Cliente()
                        {
                            Dni = reader.GetString(0),
                            Nombre = reader.GetString(1),
                            Telefono = reader.GetString(2),
                            Domilicio = reader.GetString(3),
                        };
                        clientes.Add(cliente);
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

            return clientes;
        }

        public async Task<bool> TieneAlquileresAsignados(string dni)
        {
            string peticion = "SELECT id FROM alquileres " +
                              "WHERE dni = @dni " +
                              "LIMIT 1";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);

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
