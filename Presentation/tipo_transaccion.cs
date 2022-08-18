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
    public partial class tipo_transaccion : Form
    {
        private bool editar = false;
        private string id_tipo_transaccion = null;
        public tipo_transaccion()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridTipoTransaccion.SelectedRows.Count > 0)
            {
                editar = true;
                textTipoTransaccion.Text = dataGridTipoTransaccion.CurrentRow.Cells["tipo"].Value.ToString();
                id_tipo_transaccion = dataGridTipoTransaccion.CurrentRow.Cells["id_tipo_transaccion"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de transacción a editar");
            }

        }

        private void dataGridTasa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tipo_transaccion_Load(object sender, EventArgs e)
        {
            MostrasTiposTransaccion();
        }

        private void MostrasTiposTransaccion()
        {
            TipoTransaccionesDominio objtipo = new TipoTransaccionesDominio();
            dataGridTipoTransaccion.DataSource = objtipo.MostrarTipoTransaccion();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {
                    TipoTransaccionesDominio objtipo = new TipoTransaccionesDominio();
                    objtipo.insertarTipoTransaccion(textTipoTransaccion.Text);
                    MessageBox.Show("Tipo de transacción registrada correctamente");
                    MostrasTiposTransaccion();

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tipo de transacción no registro correctamente:"+ex);
                }
            }
            if(editar==true)
            {
                try
                {
                    TipoTransaccionesDominio objtipo = new TipoTransaccionesDominio();
                    objtipo.EditarTipoTransaccion(textTipoTransaccion.Text, id_tipo_transaccion);
                    MessageBox.Show("Tipo de transacción editada correctamente");
                    MostrasTiposTransaccion();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Tipo de transacción no se edito correctamente:"+ex);
                }
            }
        }
    }
}
