using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class TipoTranaccionesData
    {
        private Conexion conexion = new Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();
        DataTable comboCuenta = new DataTable();
        DataTable comboMoneda = new DataTable();


        public DataTable MostrarTiposTransacciones()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec select_tipo_transacciones";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConnetion();
            return tabla;
        }

        public void insertarTipoTransaccion(string tipo)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec insert_tipo_transacciones '" + tipo + "'";
            comando.ExecuteNonQuery();
        }

        public void EditarTipoTransaccion(string tipo, int id_tipo_transaccion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec update_tipo_transacciones '"+tipo+"',"+id_tipo_transaccion+"";
            comando.ExecuteNonQuery();
        }
    }

  
}
