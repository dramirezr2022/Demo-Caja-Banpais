using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace DataAcces
{
    public class HistorialData
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        SqlDataReader leer1;
        DataTable tabla = new DataTable();
        DataTable tabla1 = new DataTable();
        SqlCommand comando = new SqlCommand();
        DataTable comboCuenta = new DataTable();
        DataTable comboMoneda = new DataTable();



        public DataTable BuscaCliente(int cuenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec select_historial_cliente "+cuenta+" ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConnetion();
            return tabla;

        }
        public DataTable movimientos(int cuenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec select_movimientos " + cuenta + " ";
            leer1 = comando.ExecuteReader();
            tabla1.Load(leer1);
            conexion.CerrarConnetion();
            return tabla1;
        }
  
    }
}
