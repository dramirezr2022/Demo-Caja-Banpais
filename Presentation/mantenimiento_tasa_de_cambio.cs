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
    public partial class mantenimiento_tasa_de_cambio : Form
    {
        mantenimiento_tasa_cambio_dominio objTasa = new mantenimiento_tasa_cambio_dominio();
        private bool editar = false;
        private string id_tasa = null;
        public mantenimiento_tasa_de_cambio()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            menu_mantenimientos principal = new menu_mantenimientos();
            principal.Show();
            principal.FormClosed += tasa;
            this.Close();
        }
        private void tasa(object sender, FormClosedEventArgs e)
        {

            this.Show();
        }

        private void mantenimiento_tasa_de_cambio_Load(object sender, EventArgs e)
        {
            MostrarTasa();
            MostrarMonedas();
        }
        private void MostrarTasa()
        {
            mantenimiento_tasa_cambio_dominio objTasa = new mantenimiento_tasa_cambio_dominio();
            dataGridTasa.DataSource = objTasa.MostrarTasa();
        }
        private void MostrarMonedas()
        {
            mantenimiento_tasa_cambio_dominio objMonedas = new mantenimiento_tasa_cambio_dominio();
            comboBoxMoneda.DataSource = objMonedas.tipoMoneda();
            comboBoxMoneda.DisplayMember = "id_tipo_moneda";
            comboBoxMoneda.ValueMember = "moneda";
            comboBoxMoneda.Text = "Seleccione tipo de moneda";
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridTasa.SelectedRows.Count > 0)
            {
                editar = true;
                textTasa.Text = dataGridTasa.CurrentRow.Cells["tasa"].Value.ToString();
                comboBoxMoneda.Text = dataGridTasa.CurrentRow.Cells["id_tipo_moneda"].Value.ToString();
                id_tasa = dataGridTasa.CurrentRow.Cells["id_tasa_cambio"].Value.ToString();
                

            }
            else
            {
                MessageBox.Show("Seleccione el cliente a editar");
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    comboBoxMoneda.Visible = true;
                    objTasa.insertarTasa(textTasa.Text, comboBoxMoneda.Text, dateTimePicker1.Value.ToString());
                    MessageBox.Show("Tipo de cuenta registrado correctamente");
                    MostrarTasa();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al intentar registrar tipo de cuenta:" + ex + 'L'+ textTasa.Text + 'L'+ dateTimePicker1.Value + 'L' + comboBoxMoneda.Text);
                }
            }
            if (editar == true)
            {
                try
                {
                    comboBoxMoneda.Visible = false;
                     objTasa.editarTipoTasa(id_tasa, comboBoxMoneda.Text, textTasa.Text);
                     MessageBox.Show("Tipo de cuenta actualizado correctamente");
                     MostrarTasa();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el cliente:" + ex + id_tasa);
                }
            }
        }

        
    }
}
