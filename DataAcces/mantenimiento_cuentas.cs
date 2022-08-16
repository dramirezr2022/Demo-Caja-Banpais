using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class mantenimiento_cuentas
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
            comando.CommandText= "exec select_tipoCuenta_mant";
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
            comando.CommandText = "exec select_tipoMoneda_cliente";
            leer = comando.ExecuteReader();
            comboMoneda.Load(leer);
            conexion.CerrarConnetion();
            return comboMoneda;
        }



        public void InsertarTipoCuenta(string tipoCuenta, string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EXEC insert_tipo_cuenta_ahorro '" + tipoCuenta + "','" + descripcion + "',1";
            comando.ExecuteNonQuery();
        }

        public void editarTipoCuentaData(string tipoCuenta, string descripcion, int id_tipo_cuenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EXEC update_tipo_cuenta_ahorro "+ id_tipo_cuenta +",'"+ tipoCuenta+"','"+descripcion+"'";
            comando.ExecuteReader();
          
            

        }
        public void cambiarEstadoData( int id_tipo_cuenta)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EXEC estado_tipo_cuentas " + id_tipo_cuenta + "";
            comando.ExecuteReader();



        }
        

    }
}
