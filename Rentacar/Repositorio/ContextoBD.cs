using System;
using MySql.Data.MySqlClient;

namespace Rentacar.Repositorio
{
    public class ContextoBD
    {
        private static readonly string Server = "localhost";
        private static readonly string Database = "rentacar";
        private static readonly string User = "root";
        private static readonly string Password = "root";

        private MySqlConnection conexion;
        private static ContextoBD contextoBD = null;
        private ContextoBD()
        {
        }

        public static ContextoBD GetInstancia()
        {
            if (contextoBD == null)
                contextoBD = new ContextoBD();

            return contextoBD;
        }

        public MySqlConnection GetConexion()
        {
           
        
            if (conexion is null)
            {
                string url = "";
                try
                {
                     url = string
                                        .Format("Server={0}; database={1}; UID={2}; password={3}",
                                        Server, Database, User, Password);
                }
                catch(Exception ex)
                {
                     url = string
                                        .Format("Server={0}; database={1}; UID={2}; password={3}",
                                        Server, Database, "Adrian", "");
                }
                
                conexion = new MySqlConnection(url);       
            }

            return conexion;
        }

    }
}
