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
     public class TipoMonedasDomino
    {
        private TipoMonedaData objMonedas = new TipoMonedaData();

        public DataTable MostrarMonedas()
        {
            DataTable tabla = new DataTable();
            tabla = objMonedas.MostrasMonedas();
            return tabla;

        }

        public void insertarTipoMonedaDominio(string moneda, string simbolo)
        {
            objMonedas.insertarTipoMonedaData(moneda, simbolo);
        }

        public void editarMonedaDominio(string moneda, string simbolo, string id_moneda)
        {
            objMonedas.editarMonedasData(moneda, simbolo, Convert.ToInt32(id_moneda));
        }
    }
}
