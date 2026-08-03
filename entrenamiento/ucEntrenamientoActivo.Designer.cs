namespace ProyectoPOO.entrenamiento
{
    partial class ucEntrenamientoActivo
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
            this.panelIzquierdo = new System.Windows.Forms.Panel();
            this.pbEjercicio = new System.Windows.Forms.PictureBox();
            this.lblNombreEjercicio = new System.Windows.Forms.Label();
            this.panelDerecho = new System.Windows.Forms.Panel();
            this.lblSerieActual = new System.Windows.Forms.Label();
            this.lblObjetivo = new System.Windows.Forms.Label();
            this.btnSerieCompletada = new System.Windows.Forms.Button();
            this.panelIzquierdo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEjercicio)).BeginInit();
            this.panelDerecho.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucEntrenamientoActivo
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(244)))));
            this.Controls.Add(this.panelDerecho);
            this.Controls.Add(this.panelIzquierdo);
            this.Name = "ucEntrenamientoActivo";
            this.Size = new System.Drawing.Size(1026, 787);
            // 
            // panelIzquierdo
            // 
            this.panelIzquierdo.BackColor = System.Drawing.Color.White;
            this.panelIzquierdo.Controls.Add(this.lblNombreEjercicio);
            this.panelIzquierdo.Controls.Add(this.pbEjercicio);
            this.panelIzquierdo.Location = new System.Drawing.Point(30, 30);
            this.panelIzquierdo.Name = "panelIzquierdo";
            this.panelIzquierdo.Size = new System.Drawing.Size(560, 727);
            // 
            // pbEjercicio
            // 
            this.pbEjercicio.Location = new System.Drawing.Point(30, 30);
            this.pbEjercicio.Name = "pbEjercicio";
            this.pbEjercicio.Size = new System.Drawing.Size(500, 500);
            this.pbEjercicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbEjercicio.TabStop = false;
            // 
            // lblNombreEjercicio
            // 
            this.lblNombreEjercicio.AutoSize = true;
            this.lblNombreEjercicio.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Bold);
            this.lblNombreEjercicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(27)))), ((int)(((byte)(79)))));
            this.lblNombreEjercicio.Location = new System.Drawing.Point(30, 580);
            this.lblNombreEjercicio.Name = "lblNombreEjercicio";
            this.lblNombreEjercicio.Size = new System.Drawing.Size(229, 47);
            this.lblNombreEjercicio.Text = "SENTADILLA";
            // 
            // panelDerecho
            // 
            this.panelDerecho.BackColor = System.Drawing.Color.White;
            this.panelDerecho.Controls.Add(this.btnSerieCompletada);
            this.panelDerecho.Controls.Add(this.lblObjetivo);
            this.panelDerecho.Controls.Add(this.lblSerieActual);
            this.panelDerecho.Location = new System.Drawing.Point(615, 30);
            this.panelDerecho.Name = "panelDerecho";
            this.panelDerecho.Size = new System.Drawing.Size(380, 727);
            // 
            // lblSerieActual
            // 
            this.lblSerieActual.AutoSize = true;
            this.lblSerieActual.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblSerieActual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(180)))));
            this.lblSerieActual.Location = new System.Drawing.Point(30, 45);
            this.lblSerieActual.Name = "lblSerieActual";
            this.lblSerieActual.Size = new System.Drawing.Size(243, 32);
            this.lblSerieActual.Text = "SERIE ACTUAL: 1 / 4";
            // 
            // lblObjetivo
            // 
            this.lblObjetivo.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.lblObjetivo.ForeColor = System.Drawing.Color.DimGray;
            this.lblObjetivo.Location = new System.Drawing.Point(30, 120);
            this.lblObjetivo.Name = "lblObjetivo";
            this.lblObjetivo.Size = new System.Drawing.Size(320, 150);
            this.lblObjetivo.Text = "Objetivo:\r\n12 Repeticiones\r\n60 Kg";
            // 
            // btnSerieCompletada
            // 
            this.btnSerieCompletada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(96)))), ((int)(((byte)(180)))));
            this.btnSerieCompletada.FlatAppearance.BorderSize = 0;
            this.btnSerieCompletada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerieCompletada.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnSerieCompletada.ForeColor = System.Drawing.Color.White;
            this.btnSerieCompletada.Location = new System.Drawing.Point(30, 620);
            this.btnSerieCompletada.Name = "btnSerieCompletada";
            this.btnSerieCompletada.Size = new System.Drawing.Size(320, 65);
            this.btnSerieCompletada.Text = "SERIE COMPLETADA";
            this.btnSerieCompletada.UseVisualStyleBackColor = false;
            // 
            // Finalización
            this.panelIzquierdo.ResumeLayout(false);
            this.panelIzquierdo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbEjercicio)).EndInit();
            this.panelDerecho.ResumeLayout(false);
            this.panelDerecho.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelIzquierdo;
        private System.Windows.Forms.PictureBox pbEjercicio;
        private System.Windows.Forms.Label lblNombreEjercicio;
        private System.Windows.Forms.Panel panelDerecho;
        private System.Windows.Forms.Label lblSerieActual;
        private System.Windows.Forms.Label lblObjetivo;
        private System.Windows.Forms.Button btnSerieCompletada;

        #endregion
}
}
