using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Rentacar.Enums;
using Rentacar.Modelos;
using Rentacar.Repositorio.Interfaces;

namespace Rentacar.Repositorio.Repositorios
{
    public class RepositorioAlquiler : IRepositorioAlquiler
    {
        public async Task<bool> AsignarAccesorios(int idAlquiler, List<int> idsAccesorio)
        {
            string peticion = "";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlTransaction transaction = conexion.BeginTransaction();

            peticion = "SELECT IFNULL(SUM(acc.costo),0) " +
                    "FROM accesorios acc " +
                    "INNER JOIN accesorios_alquileres aa " +
                    "ON acc.id = aa.idAccesorio " +
                    "AND aa.idAlquiler = @idAlquiler ";

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idAlquiler", idAlquiler);
            command.Prepare();

            

            try
            {
                DbDataReader reader1 = await command.ExecuteReaderAsync();

                float antiguoCosto = 0f;

                if (reader1.HasRows)
                {
                    while (reader1.Read())
                    {
                        antiguoCosto = (float)reader1.GetDecimal(0);
                    }
                }
                reader1.Close();
                peticion = "DELETE FROM accesorios_alquileres " +
                       "WHERE idAlquiler = @idAlquiler";

                 command = new MySqlCommand(peticion, conexion);
                command.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                command.Prepare();
                int result = await command.ExecuteNonQueryAsync();

                peticion = "INSERT INTO accesorios_alquileres " +
                             "VALUES (@idAccesorio,@idAlquiler)";

                foreach (int idAccesorio in idsAccesorio)
                {
                    command = new MySqlCommand(peticion, conexion);
                    command.Parameters.AddWithValue("@idAccesorio", idAccesorio);
                    command.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                    command.Prepare();

                     result = await command.ExecuteNonQueryAsync();
                };

                peticion = "SELECT IFNULL(SUM(acc.costo),0) " +
                    "FROM accesorios acc " +
                    "INNER JOIN accesorios_alquileres aa " +
                    "ON acc.id = aa.idAccesorio " +
                    "AND aa.idAlquiler = @idAlquiler ";

                 command = new MySqlCommand(peticion, conexion);
                command.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                command.Prepare();

                DbDataReader reader2 = await command.ExecuteReaderAsync();

                float nuevoCosto = 0f;

                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        nuevoCosto = (float)reader2.GetDecimal(0);
                    }
                }
                reader2.Close();
                
                peticion = "UPDATE alquileres SET importe = (importe - " +
                    "@antiguoCosto) + @nuevoCosto where id = @idAlquiler";

                command = new MySqlCommand(peticion, conexion);
                command.Parameters.AddWithValue("@idAlquiler", idAlquiler);
                command.Parameters.AddWithValue("@nuevoCosto", nuevoCosto);
                command.Parameters.AddWithValue("@antiguoCosto", antiguoCosto);
                command.Prepare();
                 result = await command.ExecuteNonQueryAsync();

                transaction.Commit();
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex);
                transaction.Rollback();
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return true;

        }

        public async Task<bool> Borrar(int id)
        {
            string peticion = "DELETE FROM alquileres " +
                             "WHERE id = @id";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@id", id);
            command.Prepare();

            try
            {
                int result = await command.ExecuteNonQueryAsync();
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return true;
        }

        public async Task<bool> Crear(Alquiler alquiler)
        {
            string peticion = "INSERT INTO alquileres " +
                              "VALUES (default, @matricula, @dni, @fechaInicio, @fechaFin, @importe)";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", alquiler.Vehiculo.Matricula);
            command.Parameters.AddWithValue("@dni", alquiler.Cliente.Dni);
            command.Parameters.AddWithValue("@fechaInicio", alquiler.FechaInicio);
            command.Parameters.AddWithValue("@fechaFin", alquiler.FechaFin);
            command.Parameters.AddWithValue("@importe", alquiler.Importe);
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

        public async Task<List<Alquiler>> Listar()
        {
            string peticion = "SELECT a.*, IFNULL(SUM(ac.costo),0) " +
                              "FROM alquileres a " +
                              "LEFT JOIN accesorios_alquileres aa " +
                              "ON a.id = aa.idAlquiler " +
                              "LEFT JOIN accesorios ac " +
                              "ON aa.idAccesorio = ac.id " +
                              "GROUP BY a.id";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);

            List<Alquiler> alquileres = new List<Alquiler>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Alquiler alquiler;

                    while (reader.Read())
                    {
                        alquiler = new Alquiler()
                        {
                            Id = reader.GetInt32(0),
                            Vehiculo = new Vehiculo() { Matricula = reader.GetString(1) },
                            Cliente = new Cliente() { Dni = reader.GetString(2) },
                            FechaInicio = reader.GetDateTime(3),
                            FechaFin = reader.GetDateTime(4),
                            Importe = reader.GetFloat(5),
                            CostoTotalAccesorios = (float)reader.GetDecimal(6)
                        };


                        alquileres.Add(alquiler);
                    }
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return alquileres;
        }

        public async Task<List<Alquiler>> ListarPorFechaDetallado(DateTime inicio, DateTime fin, Orden orden)
        {
            string peticion =
                "SELECT al.id, al.fechaInicio, al.fechaFin, al.importe, " +
                        "v.matricula, v.modelo, v.capacidad, v.anio, v.pathFoto, " +
                        "m.nombre, " +
                        "c.dni, c.nombre, c.telefono, c.domicilio, " +
                        "IFNULL(SUM(ac.costo),0) " +
                "FROM alquileres al " +
                "INNER JOIN clientes c " +
                    "ON c.dni = al.dni " +
                    "AND al.fechaInicio >= @inicio " +
                    "AND al.fechaFin <= @fin " +
                "INNER JOIN vehiculos v " +
                    "ON v.matricula = al.matricula " +
                "INNER JOIN marcas m " +
                    "ON m.id = v.idMarca " +
                "LEFT JOIN accesorios_alquileres acal " +
                    "ON acal.idAlquiler = al.id " +
                "LEFT JOIN accesorios ac " +
                    "ON acal.idAccesorio = ac.id " +
                "GROUP BY al.id " +
                "ORDER BY @orden";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            string ordenarPor = "";
            ;
            switch (orden)
            {
                case Orden.CLIENTE:
                    ordenarPor = "c.dni";
                    break;
                case Orden.FECHA:
                    ordenarPor = "al.fechaInicio";
                    break;
                case Orden.MATRICULA:
                    ordenarPor = "v.matricula";
                    break;
            }

            command.Parameters.AddWithValue("@orden", ordenarPor);
            command.Parameters.AddWithValue("@inicio", inicio);
            command.Parameters.AddWithValue("@fin", fin);
            command.Prepare();

            List<Alquiler> alquileres = new List<Alquiler>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Alquiler alquiler;

                    while (reader.Read())
                    {
                        alquiler = new Alquiler()
                        {
                            Id = reader.GetInt32(0),
                            FechaInicio = reader.GetDateTime(1),
                            FechaFin = reader.GetDateTime(2),
                            Importe = reader.GetFloat(3),
                            Vehiculo = new Vehiculo()
                            {
                                Matricula = reader.GetString(4),
                                Modelo = reader.GetString(5),
                                Capacidad = reader.GetInt32(6),
                                Anio = reader.GetString(7),
                                PathFoto = reader.GetString(8),
                                Marca = new Marca()
                                {
                                    Nombre = reader.GetString(9)
                                },
                            },
                            Cliente = new Cliente()
                            {
                                Dni = reader.GetString(10),
                                Nombre = reader.GetString(11),
                                Telefono = reader.GetString(12),
                                Domilicio = reader.GetString(13),
                            },
                            CostoTotalAccesorios = reader.GetFloat(14)
                        };

                        alquileres.Add(alquiler);
                    }
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return alquileres;
        }

        public async Task<List<Alquiler>> ListarPorFechaResumido(DateTime inicio, DateTime fin, Orden orden)
        {
            string peticion = "SELECT al.id, al.fechaInicio, al.fechaFin, " +
                                       "v.matricula, v.modelo," +
                                       "m.nombre, " +
                                       "c.dni, c.nombre " +
                                       "FROM alquileres al "+
                              "INNER JOIN clientes c " +
                              "ON c.dni = al.dni " +
                              "AND al.fechaInicio >= @inicio " +
                              "AND al.fechaFin <= @fin " +
                              "INNER JOIN vehiculos v " +
                              "ON v.matricula = al.matricula " +
                              "INNER JOIN marcas m " +
                              "ON m.id = v.idMarca " +
                              "ORDER BY @orden";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            string ordenarPor = "";
            ;
            switch (orden)
            {
                case Orden.CLIENTE:
                    ordenarPor = "c.dni";
                    break;
                case Orden.FECHA:
                    ordenarPor = "al.fechaInicio";
                    break;
                case Orden.MATRICULA:
                    ordenarPor = "v.matricula";
                    break;
            }

            command.Parameters.AddWithValue("@orden", ordenarPor);
            command.Parameters.AddWithValue("@inicio", inicio);
            command.Parameters.AddWithValue("@fin", fin);
            command.Prepare();

            List<Alquiler> alquileres = new List<Alquiler>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Alquiler alquiler;

                    while (reader.Read())
                    {
                        alquiler = new Alquiler()
                        {
                            Id = reader.GetInt32(0),
                            FechaInicio = reader.GetDateTime(1),
                            FechaFin = reader.GetDateTime(2),
                            Vehiculo = new Vehiculo()
                            {
                                Matricula = reader.GetString(3),
                                Modelo = reader.GetString(4),
                                Marca = new Marca()
                                {
                                    Nombre = reader.GetString(5)
                                },
                            },
                            Cliente = new Cliente()
                            {
                                Dni = reader.GetString(6),
                                Nombre = reader.GetString(7)
                            }
                        };

                        alquileres.Add(alquiler);
                    }
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return alquileres;
        }

        public async Task<List<Alquiler>> ListarConClientesPorVehiculo(string matricula)
        {
            string peticion =
              "SELECT  al.fechaInicio,al.fechaFin, " +
                "al.importe, c.dni, c.nombre,IFNULL(SUM(acc.costo),0) " +
              "FROM alquileres al "+
              "INNER JOIN clientes c " +
              "ON c.dni = al.dni " +
              "AND al.matricula = @matricula "+
              "LEFT JOIN accesorios_alquileres aa " +
              "ON al.id = aa.idAlquiler " +
              "LEFT JOIN accesorios acc " +
              "ON aa.idAccesorio = acc.id " +
              "GROUP by al.id " +
              "ORDER BY al.fechaInicio";

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@matricula", matricula);
            command.Prepare();
            List<Alquiler> alquileres = new List<Alquiler>();

            try
            {
                DbDataReader reader = await command.ExecuteReaderAsync();

                if (reader.HasRows)
                {
                    Alquiler alquiler;

                    while (reader.Read())
                    {
                        alquiler = new Alquiler()
                        {
                            FechaInicio = reader.GetDateTime(0),
                            FechaFin = reader.GetDateTime(1),
                            Importe = reader.GetFloat(2),
                            Cliente = new Cliente()
                            {
                                Dni = reader.GetString(3),
                                Nombre = reader.GetString(4)
                            },
                            CostoTotalAccesorios =(float) reader.GetDecimal(5)
                        };

                        alquileres.Add(alquiler);
                    }
                }
            }
            catch (DbException ex)
            {
                Console.WriteLine(ex);
                throw ex;
            }
            finally
            {
                conexion.Close();
            }

            return alquileres;
        }
    }
}
