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
        //private static string Usuario = "";
        //private static string Password = "";
        private static string BaseDatos= "DBGestionCita";

        public static string ConexionString(bool SqlAutentication = false)
        {
            SqlConnectionStringBuilder ConstructorCC = new SqlConnectionStringBuilder()
            {

                ApplicationName = NombreAplicacion,
                IntegratedSecurity = !SqlAutentication,
                DataSource = Servidor,
                InitialCatalog = BaseDatos



            };
            /*if (SqlAutentication)
            {

                ConstructorCC.UserID = Usuario;
                ConstructorCC.Password = Password;


            }*/
            return ConstructorCC.ConnectionString;

        }
    }
}
