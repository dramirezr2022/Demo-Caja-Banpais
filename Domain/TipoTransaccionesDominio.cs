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
    public class TipoTransaccionesDominio
    {
         private TipoTranaccionesData objTipo = new TipoTranaccionesData();

        public DataTable MostrarTipoTransaccion()
        {
            DataTable tabla = new DataTable();
            tabla = objTipo.MostrarTiposTransacciones();
            return tabla;

        }

        public void insertarTipoTransaccion(string tipo)
        {
            objTipo.insertarTipoTransaccion(tipo);
        }
        public void EditarTipoTransaccion(string tipo, string id_tipo_transaccion)
        {
            objTipo.EditarTipoTransaccion(tipo, Convert.ToInt32(id_tipo_transaccion));
        }
    }
}
