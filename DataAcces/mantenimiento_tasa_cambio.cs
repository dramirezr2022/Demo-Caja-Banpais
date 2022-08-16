using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class mantenimiento_tasa_cambio
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
            comando.CommandText= "exec select_tipoTasa_mant";
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConnetion();
            return tabla;
        }

        public DataTable MostrarTipoCuenta()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec select_tipoCuenta_clientes";
            leer = comando.ExecuteReader();
            comboCuenta.Load(leer);
            conexion.CerrarConnetion();
            return comboCuenta;
        }
        public DataTable MostrarTipoMoneda()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "exec select_tipoMoneda_clientes";
            leer = comando.ExecuteReader();
            comboMoneda.Load(leer);
            conexion.CerrarConnetion();
            return comboMoneda;
        }



        public void InsertarTasa(int tasa, int moneda, string fecha)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EXEC insert_tasa_cambio " + moneda + "," + tasa + ",'"+fecha+"'";
            comando.ExecuteNonQuery();
        }

        public void editarTasa(int id_tasa_cambio, int id_tipo_moneda, int tasa)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EXEC update_tasa_cambio "+id_tasa_cambio+","+id_tipo_moneda+","+tasa+"";
            comando.ExecuteReader();
          
            

        }

    }
}
