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

            peticion = "DELETE FROM accesorios_alquileres " +
                       "WHERE idAlquiler = @idAlquiler)";

            MySqlCommand command = new MySqlCommand(peticion, conexion);
            command.Parameters.AddWithValue("@idAlquiler", idAlquiler);
            command.Prepare();

            try
            {
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

                transaction.Commit();
            }
            catch (DbException ex)
            {
                transaction.Rollback();
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
                              "VALUES (default,@matricula,@dni,@fechaInicio,@fechaFin,@importe)";

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
            string peticion = "SELECT id, matricula, dni, fechaInicio, fechaFin, importe " +
                              "FROM alquileres";

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
                        };

                        alquileres.Add(alquiler);
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

            return alquileres;
        }
       
        public async Task<List<Alquiler>> ListarPorFechaDetallado(DateTime inicio, DateTime fin, Orden orden)
        {
            string peticion = "SELECT al.id, al.fechaInicio, al.fechaFin, al.importe, " +
                                       "v.matricula, v.modelo, v.capacidad, v.anio, v.pathFoto, " +
                                       "m.nombre, " +
                                       "c.dni, c.nombre, c.telefono, c.domicilio " +
                                       "SUM(ac.costo) " +                    
                              "INNER JOIN clientes c " +
                              "ON c.dni = al.dni " +
                              "AND al.fechaInicion >= @inicio " +
                              "AND al.fechaFin <= @fin " +
                              "INNER JOIN vehiculos v " +
                              "ON v.matricula = al.matricula " +
                              "INNER JOIN marcas m " +
                              "ON m.id = v.idMarca " + 
                              "FROM alquileres al " +
                              "INNER JOIN accesorios_alquileres acal " +
                              "ON acal.idAlquiler = al.id " +
                              "INNER JOIN accesorios ac " +
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
            string peticion = "SELECT al.id, al.fechaInicio, al.fechaFin, al.importe, " +
                                       "v.matricula, v.modelo, v.capacidad, v.anio, v.pathFoto, " +
                                       "m.nombre, " +
                                       "c.dni, c.nombre, c.telefono, c.domicilio " +
                                       "SUM(ac.costo) " +
                              "INNER JOIN clientes c " +
                              "ON c.dni = al.dni " +
                              "AND al.fechaInicion >= @inicio " +
                              "AND al.fechaFin <= @fin " +
                              "INNER JOIN vehiculos v " +
                              "ON v.matricula = al.matricula " +
                              "INNER JOIN marcas m " +
                              "ON m.id = v.idMarca " +
                              "FROM alquileres al " +
                              "INNER JOIN accesorios_alquileres acal " +
                              "ON acal.idAlquiler = al.id " +
                              "INNER JOIN accesorios ac " +
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
