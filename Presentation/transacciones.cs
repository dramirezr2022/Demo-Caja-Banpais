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
using System.Data.SqlClient;

namespace Presentation
{
    public partial class transacciones : Form
    {
        private string id_cliente;
        public transacciones()
        {
            InitializeComponent();
        }

        private void MostrarDatosClientes()
        {
            transacciones_dominio obDatos = new transacciones_dominio();
            dataGridView1.DataSource = obDatos.MostrarClientes();
        }

        private void transacciones_Load(object sender, EventArgs e)
        {
            MostrarDatosClientes();
            Tipo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textCliente.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textCliente.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
            textCuenta.Text= dataGridView1.CurrentRow.Cells["Cuenta"].Value.ToString();
            textTipoCuenta.Text = dataGridView1.CurrentRow.Cells["Cuenta"].Value.ToString();
            id_cliente = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            transacciones_dominio objBuscarClientes = new transacciones_dominio();
            dataGridView1.DataSource = objBuscarClientes.BuscarCliente(Convert.ToInt32(textBuscar.Text));

        }

        private void buttonRefrescar_Click(object sender, EventArgs e)
        {
            MostrarDatosClientes();
            this.textBuscar.Clear();
        }

        private void Tipo()
        {
            transacciones_dominio objTransacciones = new transacciones_dominio();
            comboBoxTipoTransaccion.DataSource = objTransacciones.TipoTransacciones();
            comboBoxTipoTransaccion.DisplayMember = "id";
            comboBoxTipoTransaccion.ValueMember = "id";
            comboBoxTipoTransaccion.Text = "Seleccione tipo de transacción";
        }

        private void textBoxMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(textBoxMonto.Text, "  ^ [0-9]"))
            {
                textBoxMonto.Text = "";
            }
        }

        private void textBoxMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo permite un punto 
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            transacciones_dominio objInsertar = new transacciones_dominio();
            
            objInsertar.insertarTransaccion(comboBoxTipoTransaccion.Text,id_cliente,textBoxMonto.Text);
            MessageBox.Show("Transacción registrada con éxito");
            this.textCliente.Clear();
            this.textCuenta.Clear();
            this.textTipoCuenta.Clear();
            this.comboBoxTipoTransaccion.Text = " ";
            this.textBoxMonto.Clear();
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
