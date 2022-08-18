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
    public partial class manetenimiento_tipo_moneda : Form
    {
        private bool editar = false;
        private string id_moneda = null;
        
        public manetenimiento_tipo_moneda()
        {
            InitializeComponent();
        }

        private void manetenimiento_tipo_moneda_Load(object sender, EventArgs e)
        {
            MostrarMonedas();

        }
        
        private void MostrarMonedas()
        {
            TipoMonedasDomino objMonedas = new TipoMonedasDomino();
            dataGridMoneda.DataSource = objMonedas.MostrarMonedas();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if(editar==false)
            {
                try
                {
                    TipoMonedasDomino objMonedas = new TipoMonedasDomino();
                    objMonedas.insertarTipoMonedaDominio(textTipoMoneda.Text, textSimbolo.Text);
                    MessageBox.Show("Se registro con éxito el tipo de moneda");
                    MostrarMonedas();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error al registrar tipo de moneda:"+ex);
                }
            }
            if (editar == true)
            {
                try
                {
                    TipoMonedasDomino objMonedas = new TipoMonedasDomino();
                    objMonedas.editarMonedaDominio(textTipoMoneda.Text, textSimbolo.Text, id_moneda);
                    MessageBox.Show("Se actualizo con éxito el tipo de moneda");
                    MostrarMonedas();
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo editar el tipo de moneda:" + ex);
                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridMoneda.SelectedRows.Count > 0)
            {
                editar = true;
                textTipoMoneda.Text = dataGridMoneda.CurrentRow.Cells["moneda"].Value.ToString();
                textSimbolo.Text = dataGridMoneda.CurrentRow.Cells["simbolo"].Value.ToString();
                id_moneda = dataGridMoneda.CurrentRow.Cells["id_tipo_moneda"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione tipo de moneda a editar");
            }
        }
    }
}
