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
    public class RepositorioVehiculo : IRepositorioVehiculo
    {


        public async Task<bool> Borrar(string matricula)
        {
            string peticion = "DELETE FROM vehiculos " +
                              "WHERE matricula = @matricula";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", matricula);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();

                if (result == 0)
                {
                    throw new DatosNoEncontradosException("No se ha encontrado el vehiculo a borrar.");
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

        public async Task<bool> Crear(Vehiculo vehiculo)
        {
            string peticion =
                "INSERT INTO vehiculos " +
                "VALUES (@matricula, @idMarca, @modelo, @capacidad, " +
                        "@anio, @costoDia, @pathFoto)";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlTransaction transaction = conexion.BeginTransaction();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
            command.Parameters.AddWithValue("@idMarca", vehiculo.Marca.Id);
            command.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
            command.Parameters.AddWithValue("@anio", vehiculo.Anio);
            command.Parameters.AddWithValue("@costoDia", vehiculo.CostoDia);
            command.Parameters.AddWithValue("@pathFoto", vehiculo.PathFoto);
            command.Parameters.AddWithValue("@capacidad", vehiculo.Capacidad);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();

                if (!(vehiculo.Caracteristicas is null))
                {

                    peticion = "INSERT INTO caracteristicas_vehiculos " +
                                 "VALUES (@idCaracteristica,@matricula)";

                    foreach (Caracteristica caracteristica in vehiculo.Caracteristicas)
                    {
                        command = new MySqlCommand(peticion, conexion);
                        command.Parameters.AddWithValue("@idCaracteristica", caracteristica.Id);
                        command.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                        command.Prepare();

                        result = await command.ExecuteNonQueryAsync();
                    };
                }
                transaction.Commit();
            }
            catch (DbException ex)
            {
                transaction.Rollback();

                if (ex.Message.Contains("Duplicate entry"))
                {
                    throw new MatriculaYaExisteException();
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

        public async Task<List<Vehiculo>> Listar()
        {
            string peticion =
               "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                      "v.capacidad, v.costoDia, v.pathFoto " +
               "FROM vehiculos v " +
               "INNER JOIN marcas m " +
               "ON v.idMarca = m.id";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6),
                            PathFoto = reader.GetString(7),
                        };

                        vehiculos.Add(vehiculo);
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

            return vehiculos;
        }

        public async Task<bool> Modificar(Vehiculo vehiculo)
        {
            string peticion =
                "UPDATE vehiculos " +
                "SET idMarca = @idMarca, modelo = @modelo, capacidad = @capacidad, " +
                     " anio = @anio, costoDia = @costoDia, pathFoto = @pathFoto " +
                "WHERE matricula = @matricula";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlTransaction transaction = conexion.BeginTransaction();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
            command.Parameters.AddWithValue("@idMarca", vehiculo.Marca.Id);
            command.Parameters.AddWithValue("@modelo", vehiculo.Modelo);
            command.Parameters.AddWithValue("@anio", vehiculo.Anio);
            command.Parameters.AddWithValue("@costoDia", vehiculo.CostoDia);
            command.Parameters.AddWithValue("@pathFoto", vehiculo.PathFoto);
            command.Parameters.AddWithValue("@capacidad", vehiculo.Capacidad);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();


                if (!(vehiculo.Caracteristicas is null))
                {


                    peticion = "DELETE FROM caracteristicas_vehiculos " +
                            "WHERE matricula = @matricula";

                    command = new MySqlCommand(peticion, conexion);
                    command.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                    command.Prepare();

                    result = await command.ExecuteNonQueryAsync();

                    peticion = "INSERT INTO caracteristicas_vehiculos " +
                                "VALUES (@idCaracteristica,@matricula)";

                    foreach (Caracteristica caracteristica in vehiculo.Caracteristicas)
                    {
                        command = new MySqlCommand(peticion, conexion);
                        command.Parameters.AddWithValue("@idCaracteristica", caracteristica.Id);
                        command.Parameters.AddWithValue("@matricula", vehiculo.Matricula);
                        command.Prepare();

                        result = await command.ExecuteNonQueryAsync();
                    };
                }
                transaction.Commit();
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

        public async Task<Vehiculo> Obtener(string matricula)
        {
            string peticion =
               "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                      "v.capacidad, v.costoDia, v.pathFoto " +
               "FROM vehiculos v " +
               "INNER JOIN marcas m " +
               "ON v.idMarca = m.id " +
               "AND v.matricula = @matricula";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", matricula);
            command.Prepare();

            Vehiculo vehiculo = null;

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6),
                            PathFoto = reader.GetString(7),
                        };
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

            return vehiculo;
        }

        public async Task<List<Vehiculo>> ObtenerAlquiladosDistinct()
        {

            string peticion =
               "SELECT DISTINCT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                      "v.capacidad, v.costoDia, v.pathFoto " +
               "FROM vehiculos v " +
               "INNER JOIN marcas m " +
               "ON v.idMarca = m.id " +
               "INNER JOIN alquileres al " +
               "ON v.matricula = al.matricula";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6),
                            PathFoto = reader.GetString(7),
                        };

                        vehiculos.Add(vehiculo);
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

            return vehiculos;
        }

        public async Task<List<Vehiculo>> ObtenerAlquiladosGroupBy()
        {
            string peticion =
              "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                     "v.capacidad, v.costoDia, v.pathFoto " +
              "FROM vehiculos v " +
              "INNER JOIN marcas m " +
              "ON v.idMarca = m.id " +
              "INNER JOIN alquileres al " +
              "ON v.matricula = al.matricula " +
              "GROUP BY v.matricula";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6),
                            PathFoto = reader.GetString(7),
                        };

                        vehiculos.Add(vehiculo);
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

            return vehiculos;
        }

        public async Task<List<Vehiculo>> ObtenerAlquiladosPorVeces(int veces)
        {
            string peticion =
              "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                     "v.capacidad, v.costoDia, v.pathFoto " +
              "FROM vehiculos v " +
              "INNER JOIN marcas m " +
              "ON v.idMarca = m.id " +
              "INNER JOIN alquileres al " +
              "ON v.matricula = al.matricula " +
              "GROUP BY v.matricula " +
              "HAVING COUNT(al.matricula) > @veces";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@veces", veces);
            command.Prepare();

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();
                Console.WriteLine("BBBBBBBBBBBBBB");
                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6),
                            PathFoto = reader.GetString(7),
                        };

                        vehiculos.Add(vehiculo);
                        Console.WriteLine("BBBBBBBBBBBBBB" + vehiculos.Count);
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

            return vehiculos;
        }

        public async Task<List<string>> ObtenerModelosPorMarca(int idMarca)
        {
            string peticion =
               "SELECT DISTINCT modelo " +
               "FROM vehiculos  " +
               "WHERE idMarca = @idMarca ";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idMarca", idMarca);
            command.Prepare();

            List<string> modelos = new List<string>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    string modelo;

                    while (reader.Read())
                    {
                        modelo = reader.GetString(0);

                        modelos.Add(modelo);
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

            return modelos;
        }

        public async Task<List<Vehiculo>> ObtenerParecidosAMarcaYModelo(string marca, string modelo)
        {
            string peticion =
               "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                      "v.capacidad, v.costoDia, v.pathFoto " +
               "FROM vehiculos v " +
               "INNER JOIN marcas m " +
               "ON v.idMarca = m.id " +
               "AND UPPER(m.nombre) " +
               "LIKE @marca " +
               "AND UPPER(v.modelo) " +
               "LIKE @modelo";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@marca", marca.ToUpper() + "%");
            command.Parameters.AddWithValue("@modelo", modelo.ToUpper() + "%");
            command.Prepare();

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6),
                            PathFoto = reader.GetString(7),
                        };

                        vehiculos.Add(vehiculo);
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

            return vehiculos;
        }

        public async Task<List<Vehiculo>> ObtenerPorCaracteristica(int idCaracteristica)
        {
            string peticion =
               "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                      "v.capacidad, v.costoDia " +
               "FROM vehiculos v " +
               "INNER JOIN marcas m " +
               "ON v.idMarca = m.id " +
               "INNER JOIN caracteristicas_vehiculos cv " +
               "ON v.matricula = cv.matricula " +
               "AND cv.idCaracteristica = @idCaracteristica";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idCaracteristica", idCaracteristica);
            command.Prepare();

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6)
                        };

                        vehiculos.Add(vehiculo);
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

            return vehiculos;
        }

        public async Task<List<Vehiculo>> ObtenerPorMarca(int idMarca)
        {
            string peticion =
               "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                      "v.capacidad, v.costoDia " +
               "FROM vehiculos v " +
               "INNER JOIN marcas m " +
               "ON v.idMarca = m.id " +
               "AND m.id = @idMarca ";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idMarca", idMarca);
            command.Prepare();

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6)
                        };

                        vehiculos.Add(vehiculo);
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

            return vehiculos;
        }

        public async Task<List<Vehiculo>> ObtenerPorMarcaYModelo(int idMarca, string modelo)
        {
            string peticion =
               "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                      "v.capacidad, v.costoDia, v.pathFoto " +
               "FROM vehiculos v " +
               "INNER JOIN marcas m " +
               "ON v.idMarca = m.id " +
               "AND m.id = @idMarca " +
               "AND v.modelo = @modelo";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idMarca", idMarca);
            command.Parameters.AddWithValue("@modelo", modelo);
            command.Prepare();

            List<Vehiculo> vehiculos = new List<Vehiculo>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Vehiculo vehiculo;

                    while (reader.Read())
                    {
                        vehiculo = new Vehiculo()
                        {
                            Matricula = reader.GetString(0),
                            Marca = new Marca()
                            {
                                Id = reader.GetInt16(1),
                                Nombre = reader.GetString(2)
                            },
                            Modelo = reader.GetString(3),
                            Anio = reader.GetString(4),
                            Capacidad = reader.GetInt16(5),
                            CostoDia = reader.GetFloat(6),
                            PathFoto = reader.GetString(7),
                        };

                        vehiculos.Add(vehiculo);
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

            return vehiculos;
        }

        public async Task<bool> TieneAlquileresAsignados(string matricula)
        {
            string peticion =
               "SELECT v.matricula " +
               "FROM vehiculos v " +
               "INNER JOIN alquileres a " +
               "ON v.matricula = a.matricula " +
               "AND v.matricula = @matricula " +
               "LIMIT 1";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", matricula);
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
