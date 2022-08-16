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
    public class ClientesDomain
    {
        private ClientesData objClientes = new ClientesData();
        private ClientesData objCuentas = new ClientesData();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objClientes.Mostrar();
            return tabla;

        }
        public DataTable MostrarCuentas()
        {
            DataTable comboCuenta = new DataTable();
            comboCuenta = objCuentas.MostrarTipoCuenta();
            return comboCuenta;

        }
        public DataTable MostrarMonedas()
        {
            DataTable comboMonedas = new DataTable();
            comboMonedas = objCuentas.MostrarTipoMoneda();
            return comboMonedas;

        }

        public void insertar (string nombre, string edad, string sexo, string telefono_fijo, string celular, string direccion,
             string cuenta, string tipo_cuenta, string tipo_moneda,string monto_inicial)
        {
            objClientes.Insertar(nombre, Convert.ToInt32(edad), sexo, Convert.ToInt32(telefono_fijo), Convert.ToInt32(celular), direccion, Convert.ToInt32(cuenta), Convert.ToInt32(tipo_cuenta), Convert.ToInt32(tipo_moneda), Convert.ToInt32(monto_inicial));


        }
        public void editarCliente(string nombre, string edad, string sexo, string telefono_fijo, string celular, string direccion,
             string id_cliente)
        {
            objClientes.Editar(nombre, Convert.ToInt32(edad), sexo, Convert.ToInt32(telefono_fijo), Convert.ToInt32(celular), direccion,Convert.ToInt32(id_cliente));
        }




    }
}
