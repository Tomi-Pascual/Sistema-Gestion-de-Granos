using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ToString();

        /*static public string cadena = "Data Source=DESKTOP-3OFLG0D//SQLEXPRESS;Initial Catalog=GestionDeGranos;Integrated Security=True";
        private readonly string ConexionString;
        public Conexion()
        {
            ConexionString = cadena;
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(ConexionString);
        }*/
    }
}
