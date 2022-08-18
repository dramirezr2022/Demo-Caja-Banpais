using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class TipoMonedaData
    {

        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        DataTable comboCuenta = new DataTable();
        DataTable comboMoneda = new DataTable();

        public DataTable MostrasMonedas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec select_monedas";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConnetion();
            return tabla;
        }

        public void insertarTipoMonedaData(string moneda, string simbolo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec insert_monedas '"+moneda+"','"+simbolo+"'";
            comando.ExecuteNonQuery();
        }

        public void editarMonedasData(string moneda, string simbolo, int id_moneda)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText= "exec update_monedas '"+moneda+"','"+simbolo+"',"+id_moneda+"";
            comando.ExecuteNonQuery();
        }

    }
}
