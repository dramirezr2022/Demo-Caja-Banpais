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
            comboBoxTipoTransaccion.DisplayMember = "Tipo";
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
    }
}
