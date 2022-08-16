using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
namespace DataAcces
{
    public abstract class ConnetionToSql
    {
        private readonly string connectionLogin;
       
                public ConnetionToSql()
                {
                  connectionLogin = "Server=DESKTOP-DP1JHGA;DataBase=Sistema de caja; integrated security= true";
                }

                protected SqlConnection GetConnection()
                {
                    return new SqlConnection(connectionLogin);
                }
           

    }
   

    public class Conexion
    {
        private SqlConnection Connetion = new SqlConnection("Server=DESKTOP-DP1JHGA;DataBase=Sistema de caja; integrated security= true");

        public SqlConnection AbrirConexion()
        {
            if (Connetion.State == ConnectionState.Closed)
                Connetion.Open();
            return Connetion;
        }

        public SqlConnection  CerrarConnetion()
        {
            if (Connetion.State == ConnectionState.Closed)
                Connetion.Close();
            return Connetion;
        }
    }

}
