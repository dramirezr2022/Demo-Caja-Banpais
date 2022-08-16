using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Common.Cache;


namespace Presentation
{
    public partial class menu_supervisor : Form
    {
        public menu_supervisor()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendeMessage(System.IntPtr hwnd, int wmsg, int wparam, int lmparm);


        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Desea cerrar el programa?", "Alerta", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            Application.Exit();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void menu_supervisor_Load(object sender, EventArgs e)
        {
            LoadUserData();

           

                if (cacheUsuario.rol == "cajero")
                {
                labelMantenimientos.Visible = false;
                panelMantenimientos.Visible = false;

                }
            
        }
        private void LoadUserData()
        {
            labelNombre.Text = cacheUsuario.nombre;
        }

        private void menu_supervisor_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendeMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            login cerrarSesion = new login();

            if (MessageBox.Show("¿Desea cerrar la sesión?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                cerrarSesion.Show();
            this.Hide();
                


        }

        private void horaFecha_Tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("h:mm");
            labelFecha.Text = DateTime.Now.ToLongDateString();

        }

        private void lblClientes_Click(object sender, EventArgs e)
        {
            clientes vistaClientes = new clientes();
            vistaClientes.Show();
            vistaClientes.FormClosed += menu;
            this.Hide();
        }
        private void menu(object sender, FormClosedEventArgs e)
        {
            
            this.Show();
        }
        private void labelMantenimientos_Click(object sender, EventArgs e)
        {
            menu_mantenimientos vistaMantenimientos = new menu_mantenimientos();
            vistaMantenimientos.Show();
            vistaMantenimientos.FormClosed += menu;
            this.Hide();
        }
    }
}
