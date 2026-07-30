namespace ProyectoPOO
{
    partial class Form1
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
            this.lblBienvenidoDeNuevo = new System.Windows.Forms.Label();
            this.lblIniciaSesionParaContinuar = new System.Windows.Forms.Label();
            this.lblOlvidarContraseña = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.btnMinimizar = new FontAwesome.Sharp.IconButton();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnIniciarSesion = new FontAwesome.Sharp.IconButton();
            this.btnRegistar = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenidoDeNuevo
            // 
            this.lblBienvenidoDeNuevo.AutoSize = true;
            this.lblBienvenidoDeNuevo.BackColor = System.Drawing.Color.White;
            this.lblBienvenidoDeNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidoDeNuevo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(103)))));
            this.lblBienvenidoDeNuevo.Location = new System.Drawing.Point(782, 210);
            this.lblBienvenidoDeNuevo.Name = "lblBienvenidoDeNuevo";
            this.lblBienvenidoDeNuevo.Size = new System.Drawing.Size(287, 25);
            this.lblBienvenidoDeNuevo.TabIndex = 3;
            this.lblBienvenidoDeNuevo.Text = "¡BIENVENIDO DE NUEVO!";
            // 
            // lblIniciaSesionParaContinuar
            // 
            this.lblIniciaSesionParaContinuar.AutoSize = true;
            this.lblIniciaSesionParaContinuar.BackColor = System.Drawing.Color.White;
            this.lblIniciaSesionParaContinuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIniciaSesionParaContinuar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(34)))), ((int)(((byte)(29)))));
            this.lblIniciaSesionParaContinuar.Location = new System.Drawing.Point(811, 239);
            this.lblIniciaSesionParaContinuar.Name = "lblIniciaSesionParaContinuar";
            this.lblIniciaSesionParaContinuar.Size = new System.Drawing.Size(238, 24);
            this.lblIniciaSesionParaContinuar.TabIndex = 4;
            this.lblIniciaSesionParaContinuar.Text = "Inicia sesión para continuar";
            // 
            // lblOlvidarContraseña
            // 
            this.lblOlvidarContraseña.AutoSize = true;
            this.lblOlvidarContraseña.BackColor = System.Drawing.Color.White;
            this.lblOlvidarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(34)))), ((int)(((byte)(29)))));
            this.lblOlvidarContraseña.Location = new System.Drawing.Point(936, 407);
            this.lblOlvidarContraseña.Name = "lblOlvidarContraseña";
            this.lblOlvidarContraseña.Size = new System.Drawing.Size(179, 18);
            this.lblOlvidarContraseña.TabIndex = 10;
            this.lblOlvidarContraseña.Text = "¿Olvidaste tu contraseña?";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.txtUsuario.Location = new System.Drawing.Point(787, 297);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(310, 28);
            this.txtUsuario.TabIndex = 11;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContraseña
            // 
            this.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(209)))), ((int)(((byte)(239)))));
            this.txtContraseña.Location = new System.Drawing.Point(787, 365);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(310, 28);
            this.txtContraseña.TabIndex = 12;
            this.txtContraseña.Text = "Contraseña";
            this.txtContraseña.Enter += new System.EventHandler(this.txtContraseña_Enter);
            this.txtContraseña.Leave += new System.EventHandler(this.txtContraseña_Leave);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(198)))), ((int)(((byte)(228)))));
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnMinimizar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.btnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimizar.IconSize = 30;
            this.btnMinimizar.Location = new System.Drawing.Point(1147, 8);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 22);
            this.btnMinimizar.TabIndex = 15;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(198)))), ((int)(((byte)(228)))));
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(43)))), ((int)(((byte)(74)))));
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 30;
            this.btnCerrar.Location = new System.Drawing.Point(1191, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(34, 27);
            this.btnCerrar.TabIndex = 14;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.BackColor = System.Drawing.Color.White;
            this.btnIniciarSesion.BackgroundImage = global::ProyectoPOO.Properties.Resources.btnLogin;
            this.btnIniciarSesion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIniciarSesion.FlatAppearance.BorderSize = 0;
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnIniciarSesion.IconColor = System.Drawing.Color.Black;
            this.btnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIniciarSesion.Location = new System.Drawing.Point(745, 435);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(371, 49);
            this.btnIniciarSesion.TabIndex = 9;
            this.btnIniciarSesion.Text = "Iniciar sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = false;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // btnRegistar
            // 
            this.btnRegistar.BackColor = System.Drawing.Color.White;
            this.btnRegistar.BackgroundImage = global::ProyectoPOO.Properties.Resources.btnRegistrar;
            this.btnRegistar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistar.FlatAppearance.BorderSize = 0;
            this.btnRegistar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(53)))), ((int)(((byte)(83)))));
            this.btnRegistar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistar.IconColor = System.Drawing.Color.Black;
            this.btnRegistar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRegistar.Location = new System.Drawing.Point(745, 514);
            this.btnRegistar.Name = "btnRegistar";
            this.btnRegistar.Size = new System.Drawing.Size(370, 72);
            this.btnRegistar.TabIndex = 8;
            this.btnRegistar.Text = "¿Nuevo por aqui?\r\nCrea tu cuenta y comienza hoy.";
            this.btnRegistar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistar.UseVisualStyleBackColor = false;
            this.btnRegistar.Click += new System.EventHandler(this.btnRegistar_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoPOO.Properties.Resources.RecuadroLogin;
            this.pictureBox3.Location = new System.Drawing.Point(634, -4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(592, 669);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.pictureBox2.Image = global::ProyectoPOO.Properties.Resources.LOGO;
            this.pictureBox2.Location = new System.Drawing.Point(-13, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(205, 91);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoPOO.Properties.Resources.IMGLOGIN;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(703, 680);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(198)))), ((int)(((byte)(228)))));
            this.ClientSize = new System.Drawing.Size(1227, 663);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblOlvidarContraseña);
            this.Controls.Add(this.btnIniciarSesion);
            this.Controls.Add(this.btnRegistar);
            this.Controls.Add(this.lblIniciaSesionParaContinuar);
            this.Controls.Add(this.lblBienvenidoDeNuevo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblBienvenidoDeNuevo;
        private System.Windows.Forms.Label lblIniciaSesionParaContinuar;
        private FontAwesome.Sharp.IconButton btnRegistar;
        private FontAwesome.Sharp.IconButton btnIniciarSesion;
        private System.Windows.Forms.Label lblOlvidarContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private FontAwesome.Sharp.IconButton btnMinimizar;
    }
}

