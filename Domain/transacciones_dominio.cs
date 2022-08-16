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
    public class transacciones_dominio
    {
        transacciones_DataAcces objTransacciones = new transacciones_DataAcces();

        public DataTable MostrarClientes()
        {
            DataTable tabla = new DataTable();
            tabla = objTransacciones.Mostrar();
            return tabla;

        }

        public DataTable BuscarCliente(int cuenta)
        {
            DataTable tabla = new DataTable();
            tabla = objTransacciones.BuscaCliente(cuenta);
            return tabla;

        }
        public DataTable TipoTransacciones()
        {
            DataTable tabla = new DataTable();
            tabla = objTransacciones.TipoTransacciones();
            return tabla;

        }
    }
}
