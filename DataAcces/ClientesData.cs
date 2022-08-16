using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAcces
{
    public class ClientesData
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
            comando.CommandText= "exec select_clientes";
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



        public void Insertar(string nombre, int edad, string sexo, int telefono_fijo, int celular, string direccion,
           int cuenta, int tipo_cuenta, int tipo_moneda,int monto_inicial)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EXEC insert_cliente '" + nombre+"',"+edad+",'"+sexo+"',"+telefono_fijo+","+celular+",'"+direccion+"',"+cuenta+","+tipo_cuenta+","+tipo_moneda+","+monto_inicial+","+1+" ";
            comando.ExecuteNonQuery();
        }

        public void Editar(string nombre, int edad, string sexo, int telefono_fijo, int celular, string direccion,
           int id_cliente)
        {
            /*comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "select estado from clientes where id_cliente='"+id_cliente+"'";
            leer = comando.ExecuteReader();
            if(leer!0 )
            {
                comando.CommandText = "EXEC actualizar_Cliente '" + nombre + "'," + edad + ",'" + sexo + "'," + telefono_fijo + "," + celular + ",'" + direccion + "'," + id_cliente + ","++" ";
                comando.ExecuteNonQuery();
            }*/
            

        }

    }
}
