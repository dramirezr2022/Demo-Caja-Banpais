using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentation
{
    public partial class menu_mantenimientos : Form
    {
        public menu_mantenimientos()
        {
            InitializeComponent();
        }

        private void panelMantenimientos_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu_supervisor menuPrincipal = new menu_supervisor();
            menuPrincipal.Show();
            menuPrincipal.FormClosed += mantenimientos;
            this.Hide();
        }
        private void mantenimientos(object sender, FormClosedEventArgs e)
        {

            this.Show();
        }
        private void menu_mantenimientos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            mantenimiento_tasa_de_cambio tasa = new mantenimiento_tasa_de_cambio();
            tasa.Show();
            tasa.FormClosed += mantenimientos;
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            mantenimiento_tipo_de_cuentas tipo = new mantenimiento_tipo_de_cuentas();
            tipo.Show();
            tipo.FormClosed  += mantenimientos;
            this.Hide();


        }
    }
}
