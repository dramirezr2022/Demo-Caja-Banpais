using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DataAcces;

namespace Domain
{
    public class mantenimiento_cuentas_dominio
    {
        private mantenimiento_cuentas objTipoCuentas = new mantenimiento_cuentas();
       // private ClientesData objCuentas = new ClientesData();

        public DataTable MostrarCuentas()
        {
            DataTable tabla = new DataTable();
            tabla = objTipoCuentas.Mostrar();
            return tabla;

        }
        /*public DataTable MostrarCuentas()
        {
            DataTable comboCuenta = new DataTable();
            comboCuenta = objCuentas.MostrarTipoCuenta();
            return comboCuenta;

        }*/
        public DataTable MostrarMonedas()
        {
            DataTable comboMonedas = new DataTable();
            comboMonedas = objTipoCuentas.MostrarTipoMoneda();
            return comboMonedas;

        }

        public void insertarTipoCuenta(string tipoCuenta, string descripcion)
        {
            objTipoCuentas.InsertarTipoCuenta(tipoCuenta, descripcion);


        }
        public void editarTipoCuenta(string tipoCuenta, string descripcion, string id_tipo_cuenta)
        {
            objTipoCuentas.editarTipoCuentaData(tipoCuenta,descripcion,Convert.ToInt32(id_tipo_cuenta));
        }
        public void cambiarEstado(string id_tipo_cuenta)
        {
            objTipoCuentas.cambiarEstadoData( Convert.ToInt32(id_tipo_cuenta));
        }

        

    }
}
