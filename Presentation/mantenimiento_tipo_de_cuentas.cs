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
    public partial class mantenimiento_tipo_de_cuentas : Form
    {
        mantenimiento_cuentas_dominio objCuentas = new mantenimiento_cuentas_dominio();
        private bool editar = false;
        private string id_tipo_cuenta = null;
        public mantenimiento_tipo_de_cuentas()
        {
            InitializeComponent();
        }

        private void mantenimiento_tipo_de_cuentas_Load(object sender, EventArgs e)
        {
            MostrarCuentas();
        }

        private void labelTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void menu(object sender, FormClosedEventArgs e)
        {

            this.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            menu_mantenimientos cuentas = new menu_mantenimientos();
            cuentas.Show();
            cuentas.FormClosed += menu;
            this.Hide();

        }
        private void MostrarCuentas()
        {
            mantenimiento_cuentas_dominio objCuentas = new mantenimiento_cuentas_dominio();
            dataGridCuentas.DataSource = objCuentas.MostrarCuentas();
        }
        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridCuentas.SelectedRows.Count > 0)
            {
                editar = true;
                textTipo.Text = dataGridCuentas.CurrentRow.Cells["tipo_cuenta"].Value.ToString();
                textDescripcion.Text = dataGridCuentas.CurrentRow.Cells["descripcion"].Value.ToString();
                id_tipo_cuenta = dataGridCuentas.CurrentRow.Cells["id_tipo_cuenta"].Value.ToString();
                

            }
            else
            {
                MessageBox.Show("Seleccione el tipo de cuenta a editar");
            }
        }
        private void buttonGuardarTipoCuenta_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    mantenimiento_cuentas_dominio objCuentas = new mantenimiento_cuentas_dominio();
                    objCuentas.insertarTipoCuenta(textTipo.Text, textDescripcion.Text);
                    MessageBox.Show("Tipo de cuenta registrado correctamente");
                    MostrarCuentas();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar registrar tipo de cuenta:" + ex + textTipo.Text + textDescripcion.Text);
                }
            }
            if (editar == true)
            {
                try
                {
                    mantenimiento_cuentas_dominio objCuentas = new mantenimiento_cuentas_dominio();
                    objCuentas.editarTipoCuenta(textTipo.Text, textDescripcion.Text, id_tipo_cuenta);
                    MessageBox.Show("Tipo de cuenta actualizado correctamente");
                    MostrarCuentas();
             
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el cliente:" + ex + id_tipo_cuenta);
                }
            }
        }

        private void buttonDesactivar_Click(object sender, EventArgs e)
        {
            if (dataGridCuentas.SelectedRows.Count > 0)
            {
                editar = true;
                
                id_tipo_cuenta = dataGridCuentas.CurrentRow.Cells["id_tipo_cuenta"].Value.ToString();

                if(editar==true)
                {
                    try
                    {
                        mantenimiento_cuentas_dominio objCuentas = new mantenimiento_cuentas_dominio();
                        objCuentas.cambiarEstado(id_tipo_cuenta);
                        MessageBox.Show("se cambio correctamente el estado");
                        MostrarCuentas();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al intentar registrar tipo de cuenta:" + ex + textTipo.Text + textDescripcion.Text);
                    }

                }


            }
            else
            {
                MessageBox.Show("Seleccione el tipo de cuenta");
            }

        }
    }
}
