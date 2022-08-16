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
    public partial class clientes : Form
    {
        ClientesDomain objClientes = new ClientesDomain();
        private string id_cliente = null;
        private bool editar = false;
        public clientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void clientes_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            MostrarCuentas();
            MostrarMonedas();
            comboBoxGenero.Text = "Genero";
        }

        private void MostrarClientes()
        {
            ClientesDomain objCli = new ClientesDomain();
            dataGridView1.DataSource = objCli.MostrarClientes();
        }
        private void MostrarCuentas()
        {
            ClientesDomain objCuentas = new ClientesDomain();
            comboCuentas.DataSource = objCuentas.MostrarCuentas();
            comboCuentas.DisplayMember = "tipo_cuenta";
            comboCuentas.ValueMember = "id_tipo_cuenta";
            comboCuentas.Text = "Seleccione tipo de Cuenta";
        }
        private void MostrarMonedas()
        {
            ClientesDomain objMonedas = new ClientesDomain();
            comboMoneda.DataSource = objMonedas.MostrarMonedas();
            comboMoneda.DisplayMember = "moneda";
            comboMoneda.ValueMember = "id_tipo_moneda";
            comboMoneda.Text = "Seleccione tipo de moneda";
        }



        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardarCliente_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {


                try
                {
                    objClientes.insertar(textNombre.Text, textEdad.Text, comboBoxGenero.Text, textTelefono.Text, textCelular.Text, textdireccion.Text, textcCuenta.Text, comboCuentas.Text, comboMoneda.Text,textMonto.Text);
                    MessageBox.Show("Cliente registrado correctamente");
                    MostrarClientes();
                    this.textNombre.Focus();
                    textNombre.Text = "Nombres";
                    this.textEdad.Focus();
                    textEdad.Text = "Edad";
                    this.comboBoxGenero.Focus();
                    comboBoxGenero.Text = "Genero";
                    this.textTelefono.Focus();
                    textTelefono.Text = "Teléfono";
                    this.textCelular.Focus();
                    textCelular.Text = "Celular";
                    this.textdireccion.Focus();
                    textdireccion.Text = "Dirección";
                    this.textcCuenta.Focus();
                    textcCuenta.Text = "Cuenta";
                    this.comboCuentas.Focus();
                    comboCuentas.Text = "Cuenta";
                    this.comboMoneda.Focus();
                    comboMoneda.Text = "Cuenta";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar registrar Cliente:" + ex + textNombre.Text + textEdad.Text + comboBoxGenero.Text + textTelefono.Text + textCelular.Text + textdireccion.Text + textcCuenta.Text + comboCuentas.Text + comboMoneda.Text, textMonto.Text);
                }
            }
            if(editar==true)
            {
                try
                {
                    objClientes.editarCliente(textNombre.Text, textEdad.Text, comboBoxGenero.Text, textTelefono.Text, textCelular.Text, textdireccion.Text, id_cliente);
                    MessageBox.Show("Cliente actualizado correctamente");
                    MostrarClientes();
                    editar = false;
                    this.textNombre.Focus();
                    textNombre.Text = "Nombres";
                    this.textEdad.Focus();
                    textEdad.Text = "Edad";
                    this.comboBoxGenero.Focus();
                    comboBoxGenero.Text = "Genero";
                    this.textTelefono.Focus();
                    textTelefono.Text = "Teléfono";
                    this.textCelular.Focus();
                    textCelular.Text = "Celular";
                    this.textdireccion.Focus();
                   textdireccion.Text = "Dirección";
                    this.textcCuenta.Focus();
                    textcCuenta.Text = "Cuenta";
                    this.comboCuentas.Focus();
                    comboCuentas.Text = "Seleccione tipo de Cuenta";
                    this.comboMoneda.Focus();
                    comboMoneda.Text = "Seleccione tipo de moneda";
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudo editar el cliente:"+ ex);
                }
            }
        }

        private void listTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count>0)
            {
                editar = true;
                textNombre.Text = dataGridView1.CurrentRow.Cells["nombre"].Value.ToString();
                textEdad.Text = dataGridView1.CurrentRow.Cells["edad"].Value.ToString();
                comboBoxGenero.Text = dataGridView1.CurrentRow.Cells["sexo"].Value.ToString();
                textTelefono.Text = dataGridView1.CurrentRow.Cells["Telefono"].Value.ToString();
                textCelular.Text = dataGridView1.CurrentRow.Cells["celular"].Value.ToString();
                textdireccion.Text = dataGridView1.CurrentRow.Cells["direccion"].Value.ToString();
                id_cliente = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione el cliente a editar");
            }
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

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
