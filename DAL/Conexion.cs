using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net.NetworkInformation;

namespace DAL
{
    public static class Conexion
    {
        private static string NombreAplicacion = "Agentamiento";
        private static string Servidor = "LAPTOP-9EKK179R";
        private static string Usuario = "Dubon19";
        private static string Password = "12345";
        private static string BaseDatos = "DBGestionCita";

        // Método para generar la cadena de conexión
        public static string ConexionString(bool SqlAutentication = true)
        {
            SqlConnectionStringBuilder ConstructorCC = new SqlConnectionStringBuilder()
            {
                ApplicationName = NombreAplicacion,
                IntegratedSecurity = !SqlAutentication,
                DataSource = Servidor,
                InitialCatalog = BaseDatos
            };

            if (SqlAutentication)
            {
                ConstructorCC.UserID = Usuario;
                ConstructorCC.Password = Password;
            }

            return ConstructorCC.ConnectionString;
        }

        // Método para comprobar la conexión
        public static string ComprobarConexion(bool SqlAutentication = false)
        {
            try
            {
                string connectionString = Conexion.ConexionString(SqlAutentication);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    return "Conexión exitosa a la base de datos.";
                }
            }
            catch (SqlException sqlEx)
            {
                // Mostrar detalles completos del error
                return $"Error al intentar conectar a la base de datos:{sqlEx.Message}\nDetalles: {sqlEx.StackTrace}\nCódigo de error SQL: {sqlEx.Number}";
            }
            catch (Exception ex)
            {
                return $"Error inesperado: {ex.Message}\nDetalles: {ex.StackTrace}";
            }
        }
    }
}
