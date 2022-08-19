using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class transacciones_DataAcces
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        DataTable comboCuenta = new DataTable();
        DataTable comboMoneda = new DataTable();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec select_transacciones";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConnetion();
            return tabla;
        }

        public DataTable BuscaCliente(int cuenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec BuscarCliente_transacciones "+cuenta+" ";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConnetion();
            return tabla;
            
        }

        public DataTable TipoTransacciones()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec Select_TipoTransacciones";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConnetion();
            return tabla;

        }
        public void insertarTransaccion(int tipo_transaccion,int id_cliente, string monto)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec insert_transaccion " + tipo_transaccion + ","+id_cliente+",'"+monto+"'";
            comando.ExecuteReader();

        }
    }
}
