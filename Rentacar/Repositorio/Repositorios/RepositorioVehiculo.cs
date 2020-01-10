using MySql.Data.MySqlClient;
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
        private static readonly string LISTAR =
            "SELECT v.matricula, m.id, m.nombre, v.modelo, v.anio, " +
                   "v.capacidad, v.costoDia, v.pathFoto " +
            "FROM vehiculos v " +
            "INNER JOIN marcas m " +
            "ON v.idMarca = m.id";

        public Task<bool> AsignarCaracteristicas(string matricula, List<int> idsCaracteristica)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Borrar(string matricula)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Crear(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Vehiculo>> Listar()
        {

            var conexion = ContextoBD.GetInstancia().GetConexion();
            conexion.Open();
            MySqlCommand command = new MySqlCommand(LISTAR, conexion);
            DbDataReader reader = await command.ExecuteReaderAsync();

            List<Vehiculo> vehiculos = new List<Vehiculo>();

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
            
            conexion.Close();

            return vehiculos;
        }

        public Task<bool> Modificar(Vehiculo vehiculo)
        {
            throw new NotImplementedException();
        }

        public Task<Vehiculo> Obtener(string matricula)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vehiculo>> ObtenerAlquiladosDistinct()
        {
            throw new NotImplementedException();
        }

        public Task<List<Vehiculo>> ObtenerAlquiladosGroupBy()
        {
            throw new NotImplementedException();
        }

        public Task<List<Vehiculo>> ObtenerAlquiladosPorVeces(int veces)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vehiculo>> ObtenerPorCaracteristica(int idCaracteristica)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vehiculo>> ObtenerPorMarcaYModelo(int idMarca, string modelo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> QuitarCaracteristicas(string matricula)
        {
            throw new NotImplementedException();
        }
    }
}
