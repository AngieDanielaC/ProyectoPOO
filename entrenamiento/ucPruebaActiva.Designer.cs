namespace ProyectoPOO.entrenamiento
{
    partial class ucPruebaActiva
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelCronometro = new System.Windows.Forms.Panel();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblTituloPrueba = new System.Windows.Forms.Label();
            this.panelControles = new System.Windows.Forms.Panel();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnIniciarPausar = new System.Windows.Forms.Button();
            this.timerCrono = new System.Windows.Forms.Timer(this.components);
            this.panelCronometro.SuspendLayout();
            this.panelControles.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucPruebaActiva
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panelControles);
            this.Controls.Add(this.panelCronometro);
            this.Name = "ucPruebaActiva";
            this.Size = new System.Drawing.Size(1026, 787);
            // 
            // panelCronometro
            // 
            this.panelCronometro.BackColor = System.Drawing.Color.White;
            this.panelCronometro.Controls.Add(this.lblTiempo);
            this.panelCronometro.Controls.Add(this.lblTituloPrueba);
            this.panelCronometro.Location = new System.Drawing.Point(30, 30);
            this.panelCronometro.Name = "panelCronometro";
            this.panelCronometro.Size = new System.Drawing.Size(966, 300);
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Font = new System.Drawing.Font("Segoe UI", 65F, System.Drawing.FontStyle.Bold);
            this.lblTiempo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(79)))));
            this.lblTiempo.Location = new System.Drawing.Point(280, 95);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(402, 116);
            this.lblTiempo.Text = "00:00:00";
            // 
            // lblTituloPrueba
            // 
            this.lblTituloPrueba.AutoSize = true;
            this.lblTituloPrueba.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTituloPrueba.ForeColor = System.Drawing.Color.DarkGray;
            this.lblTituloPrueba.Location = new System.Drawing.Point(40, 30);
            this.lblTituloPrueba.Name = "lblTituloPrueba";
            this.lblTituloPrueba.Size = new System.Drawing.Size(337, 30);
            this.lblTituloPrueba.Text = "TEST DE COOPER EN PROGRESO";
            // 
            // panelControles
            // 
            this.panelControles.BackColor = System.Drawing.Color.White;
            this.panelControles.Controls.Add(this.btnFinalizar);
            this.panelControles.Controls.Add(this.btnIniciarPausar);
            this.panelControles.Location = new System.Drawing.Point(30, 360);
            this.panelControles.Name = "panelControles";
            this.panelControles.Size = new System.Drawing.Size(966, 397);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(510, 160);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(360, 80);
            this.btnFinalizar.Text = "FINALIZAR PRUEBA";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            // 
            // btnIniciarPausar
            // 
            this.btnIniciarPausar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(180)))));
            this.btnIniciarPausar.FlatAppearance.BorderSize = 0;
            this.btnIniciarPausar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciarPausar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.btnIniciarPausar.ForeColor = System.Drawing.Color.White;
            this.btnIniciarPausar.Location = new System.Drawing.Point(90, 160);
            this.btnIniciarPausar.Name = "btnIniciarPausar";
            this.btnIniciarPausar.Size = new System.Drawing.Size(360, 80);
            this.btnIniciarPausar.Text = "INICIAR PRUEBA";
            this.btnIniciarPausar.UseVisualStyleBackColor = false;
            // 
            // timerCrono
            // 
            this.timerCrono.Interval = 1000;
            // 
            // Finalización
            this.panelCronometro.ResumeLayout(false);
            this.panelCronometro.PerformLayout();
            this.panelControles.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelCronometro;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblTituloPrueba;
        private System.Windows.Forms.Panel panelControles;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnIniciarPausar;
        private System.Windows.Forms.Timer timerCrono;

        #endregion
}
}
