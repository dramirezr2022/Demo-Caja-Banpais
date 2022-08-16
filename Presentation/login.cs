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
using Domain;

namespace Presentation
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textUser.Text != "")
            {
                if (textPass.Text != "CONTRASEÑA")
                {
                    UserModel user = new UserModel();
                    var validarLogin = user.LoginUser(textUser.Text, textPass.Text);
                    if (validarLogin == true)
                    {
                        menu_supervisor menuPrincipal = new menu_supervisor();
                        menuPrincipal.Show();
                        menuPrincipal.FormClosed += Logout;
                        this.Hide();
                    }
                    else msgError("Usuario o contraseña incorrectos.");
                    textPass.Text = "CONTRASEÑA";
                    textUser.Focus();

                }
                else msgError("Favor ingresar contraseña");
            }
            else msgError("Favor ingrese usuario");
        }
        private void msgError(string msg)
        {
            labeError.Text =msg;
            labeError.Visible = true;
        }

        private void Logout(object sender, FormClosedEventArgs e)
        {
            textUser.Text="USUARIO";
            textPass.Text="CONTRASEÑA";
            textPass.UseSystemPasswordChar = false;
            labeError.Visible = false;
            this.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa?", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Application.Exit();
        }

        private void minimizarLogin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void textUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelMostrar_Click(object sender, EventArgs e)
        {
            labelOcultar.BringToFront();
            textPass.PasswordChar = '\0';


        }

        private void labelOcultar_Click(object sender, EventArgs e)
        {
            labelMostrar.BringToFront();
            textPass.PasswordChar = '*';
        }
    }
}
