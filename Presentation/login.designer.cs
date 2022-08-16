namespace Presentation
{
    partial class login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.labeError = new System.Windows.Forms.Label();
            this.minimizarLogin = new System.Windows.Forms.PictureBox();
            this.cerrar = new System.Windows.Forms.PictureBox();
            this.labelMostrar = new System.Windows.Forms.Label();
            this.labelOcultar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 330);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Presentation.Properties.Resources._81376553_2883940401625738_3641283426851487744_n;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 330);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(391, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "INICIAR SESION";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(308, 125);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 1);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(308, 183);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(348, 1);
            this.panel3.TabIndex = 3;
            // 
            // textUser
            // 
            this.textUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.textUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textUser.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.textUser.Location = new System.Drawing.Point(308, 99);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(348, 24);
            this.textUser.TabIndex = 4;
            this.textUser.Text = "USUARIO";
            this.textUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textUser.TextChanged += new System.EventHandler(this.textUser_TextChanged);
            // 
            // textPass
            // 
            this.textPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.textPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textPass.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.textPass.Location = new System.Drawing.Point(308, 153);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(348, 24);
            this.textPass.TabIndex = 5;
            this.textPass.Text = "CONTRASEÑA";
            this.textPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textPass.TextChanged += new System.EventHandler(this.textPass_TextChanged);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(414, 272);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "ACCEDER";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labeError
            // 
            this.labeError.AutoSize = true;
            this.labeError.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.labeError.Image = global::Presentation.Properties.Resources.pngtree_vector_cross_icon_png_image_952284;
            this.labeError.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labeError.Location = new System.Drawing.Point(325, 227);
            this.labeError.Name = "labeError";
            this.labeError.Size = new System.Drawing.Size(50, 23);
            this.labeError.TabIndex = 9;
            this.labeError.Text = "Error";
            this.labeError.Visible = false;
            // 
            // minimizarLogin
            // 
            this.minimizarLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizarLogin.Image = global::Presentation.Properties.Resources.minimazar;
            this.minimizarLogin.Location = new System.Drawing.Point(722, 12);
            this.minimizarLogin.Name = "minimizarLogin";
            this.minimizarLogin.Size = new System.Drawing.Size(20, 20);
            this.minimizarLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizarLogin.TabIndex = 8;
            this.minimizarLogin.TabStop = false;
            this.minimizarLogin.Click += new System.EventHandler(this.minimizarLogin_Click);
            // 
            // cerrar
            // 
            this.cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cerrar.Image = global::Presentation.Properties.Resources.cerrar;
            this.cerrar.Location = new System.Drawing.Point(748, 12);
            this.cerrar.Name = "cerrar";
            this.cerrar.Size = new System.Drawing.Size(20, 20);
            this.cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cerrar.TabIndex = 7;
            this.cerrar.TabStop = false;
            this.cerrar.Click += new System.EventHandler(this.cerrar_Click);
            // 
            // labelMostrar
            // 
            this.labelMostrar.AutoSize = true;
            this.labelMostrar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMostrar.Location = new System.Drawing.Point(451, 187);
            this.labelMostrar.Name = "labelMostrar";
            this.labelMostrar.Size = new System.Drawing.Size(78, 22);
            this.labelMostrar.TabIndex = 10;
            this.labelMostrar.Text = "Mostrar";
            this.labelMostrar.Click += new System.EventHandler(this.labelMostrar_Click);
            // 
            // labelOcultar
            // 
            this.labelOcultar.AutoSize = true;
            this.labelOcultar.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOcultar.Location = new System.Drawing.Point(449, 187);
            this.labelOcultar.Name = "labelOcultar";
            this.labelOcultar.Size = new System.Drawing.Size(80, 22);
            this.labelOcultar.TabIndex = 11;
            this.labelOcultar.Text = "Ocultar";
            this.labelOcultar.Click += new System.EventHandler(this.labelOcultar_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(63)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(780, 330);
            this.Controls.Add(this.labelMostrar);
            this.Controls.Add(this.labelOcultar);
            this.Controls.Add(this.labeError);
            this.Controls.Add(this.minimizarLogin);
            this.Controls.Add(this.cerrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(0)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.login_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cerrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox cerrar;
        private System.Windows.Forms.PictureBox minimizarLogin;
        private System.Windows.Forms.Label labeError;
        private System.Windows.Forms.Label labelMostrar;
        private System.Windows.Forms.Label labelOcultar;
    }
}

