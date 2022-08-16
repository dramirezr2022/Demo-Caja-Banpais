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
    public class mantenimiento_tasa_cambio_dominio
    {
        private mantenimiento_tasa_cambio objTasa = new mantenimiento_tasa_cambio();
       // private ClientesData objCuentas = new ClientesData();

        public DataTable MostrarTasa()
        {
            DataTable tabla = new DataTable();
            tabla = objTasa.Mostrar();
            return tabla;

        }
        public DataTable tipoMoneda()
        {
            DataTable comboMonedas = new DataTable();
            comboMonedas = objTasa.MostrarTipoMoneda();
            return comboMonedas;

        }


        public void insertarTasa(string tasa, string moneda, string fecha )
        {
            objTasa.InsertarTasa(Convert.ToInt32(tasa), Convert.ToInt32(moneda), fecha);

        }
        public void editarTipoTasa(string id_tipo_tasa, string idMoneda ,string tasa )
        {
            objTasa.editarTasa(Convert.ToInt32(id_tipo_tasa), Convert.ToInt32(idMoneda), Convert.ToInt32(tasa));

        }
        



    }
}
