using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAcces;
using System.Data;
using System.Data.SqlClient;


namespace Domain
{

    public class HistorialClientesDominio
    {
        HistorialData objHistorial = new HistorialData();   
        

        public DataTable BuscaCliente(string cuenta)
        {
            DataTable historial = new DataTable();
            historial = objHistorial.BuscaCliente(Convert.ToInt32(cuenta));
            return historial;
        }
        public DataTable movimientos(string cuenta)
        {
            DataTable historial = new DataTable();
            historial = objHistorial.movimientos(Convert.ToInt32(cuenta));
            return historial;
        }
    }
}
