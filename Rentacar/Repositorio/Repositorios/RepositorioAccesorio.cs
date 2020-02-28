using MySql.Data.MySqlClient;
using Rentacar.Excepciones;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioAccesorio : IRepositorioAccesorio
    {
        public async Task<bool> Borrar(int idAccesorio)
        {
            string peticion = "DELETE FROM accesorios " +
                              "WHERE id = @idAccesorio";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idAccesorio", idAccesorio);
            command.Prepare();

            try
            {
                int result =  await command.ExecuteNonQueryAsync();

                if (result == 0)
                {
                    throw new DatosNoEncontradosException("No se ha encontrado el accesorio a borrar.");
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

        public async Task<bool> Crear(Accesorio accesorio)
        {
            string peticion = "INSERT INTO accesorios " +
                              "VALUES (default,@nombre,@costo)";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@nombre", accesorio.Nombre);
            command.Parameters.AddWithValue("@costo", accesorio.Costo);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();
            }
            catch (DbException ex)
            {
                if (ex.Message.Contains("UC_nombre_accesorio"))
                {
                    throw new NombreAccesorioYaExisteException();
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

        public async Task<List<Accesorio>> Listar()
        {
            string peticion = 
                "SELECT * FROM accesorios " +
                "ORDER BY nombre";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Accesorio> accesorios = new List<Accesorio>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Accesorio accesorio;

                    while (reader.Read())
                    {
                        accesorio = new Accesorio()
                        {
                            Id = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Costo = reader.GetFloat(2)
                        };
                        accesorios.Add(accesorio);
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

            return accesorios;
        }

        public async Task<bool> Modificar(Accesorio accesorio)
        {
            string peticion = "UPDATE accesorios " +
                               "SET nombre = @nombre, costo = @costo " +
                               "WHERE id = @id";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@nombre", accesorio.Nombre);
            command.Parameters.AddWithValue("@costo", accesorio.Costo);
            command.Parameters.AddWithValue("@id", accesorio.Id);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();
            }
            catch (DbException ex)
            {
                if (ex.Message.Contains("UC_nombre"))
                {
                    throw new NombreAccesorioYaExisteException();
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

        public async Task<bool> TieneAlquileresAsignados(int idAccesorio)
        {
            string peticion =
                 "SELECT a.id FROM accesorios a " +
                 "INNER JOIN accesorios_alquileres aa " +
                     "ON a.id = aa.idAccesorio " +
                     "AND a.id = @idAccesorio " +
                 "LIMIT 1";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idAccesorio", idAccesorio);
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
