using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;

namespace Presentation
{
    public partial class historial_clientes : Form
    {
        public historial_clientes()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            HistorialClientesDominio objDatos = new HistorialClientesDominio();
            dataGridView1.DataSource = objDatos.BuscaCliente(textBuscar.Text);
            dataGridView1.Visible = false;
            textCliente.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textCuenta.Text = dataGridView1.CurrentRow.Cells["Cuenta"].Value.ToString();
            textSaldo.Text = dataGridView1.CurrentRow.Cells["Saldo"].Value.ToString();
            dataGridMovimientos.DataSource = objDatos.movimientos(textBuscar.Text);
        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            this.textBuscar.Clear();
            this.textCliente.Clear();
            this.textCuenta.Clear();
            this.textSaldo.Clear();
            this.dataGridMovimientos.Columns.Clear();
            this.dataGridView1.Columns.Clear();
            
        }

        private void historial_clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu_supervisor vistaMenu = new menu_supervisor();
            vistaMenu.Show();
            vistaMenu.FormClosed += menu;
            this.Hide();
        }
        private void menu(object sender, FormClosedEventArgs e)
        {

            this.Show();
        }
    }
}
