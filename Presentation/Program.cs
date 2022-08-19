using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    static class Presentation
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
            //Application.Run(new clientes());
            //Application.Run(new menu_supervisor());
            //Application.Run(new menu_mantenimientos());
            //Application.Run(new mantenimiento_tasa_de_cambio());
            //Application.Run(new mantenimiento_tipo_de_cuentas());
            //Application.Run(new transacciones());
            //Application.Run(new tipo_transaccion());
            //Application.Run(new manetenimiento_tipo_moneda());
            //Application.Run(new historial_clientes());

        }
    }
}
