namespace ProyectoPOO
{
    partial class ucBienestar
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
            this.button1 = new System.Windows.Forms.Button();
            this.lblMainBienestar = new System.Windows.Forms.Label();
            this.panelBienestar = new System.Windows.Forms.Panel();
            this.btnVD = new System.Windows.Forms.Button();
            this.btnGC = new System.Windows.Forms.Button();
            this.btnRFatiga = new System.Windows.Forms.Button();
            this.panelBienestarBackground = new System.Windows.Forms.Panel();
            this.panelBienestar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 620);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 124);
            this.button1.TabIndex = 0;
            this.button1.Text = "FUER ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lblMainBienestar
            // 
            this.lblMainBienestar.BackColor = System.Drawing.Color.White;
            this.lblMainBienestar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMainBienestar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblMainBienestar.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainBienestar.Location = new System.Drawing.Point(0, 0);
            this.lblMainBienestar.Name = "lblMainBienestar";
            this.lblMainBienestar.Size = new System.Drawing.Size(337, 89);
            this.lblMainBienestar.TabIndex = 1;
            this.lblMainBienestar.Text = "BIENESTAR";
            // 
            // panelBienestar
            // 
            this.panelBienestar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(63)))), ((int)(((byte)(112)))));
            this.panelBienestar.Controls.Add(this.button1);
            this.panelBienestar.Controls.Add(this.lblMainBienestar);
            this.panelBienestar.Controls.Add(this.btnVD);
            this.panelBienestar.Controls.Add(this.btnGC);
            this.panelBienestar.Controls.Add(this.btnRFatiga);
            this.panelBienestar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBienestar.Location = new System.Drawing.Point(0, 0);
            this.panelBienestar.Name = "panelBienestar";
            this.panelBienestar.Size = new System.Drawing.Size(240, 787);
            this.panelBienestar.TabIndex = 2;
            // 
            // btnVD
            // 
            this.btnVD.FlatAppearance.BorderSize = 0;
            this.btnVD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(34)))), ((int)(((byte)(29)))));
            this.btnVD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVD.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVD.ForeColor = System.Drawing.Color.White;
            this.btnVD.Image = global::ProyectoPOO.Properties.Resources._5;
            this.btnVD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVD.Location = new System.Drawing.Point(0, 388);
            this.btnVD.Margin = new System.Windows.Forms.Padding(4);
            this.btnVD.Name = "btnVD";
            this.btnVD.Size = new System.Drawing.Size(269, 99);
            this.btnVD.TabIndex = 5;
            this.btnVD.Text = "Visualizar Datos";
            this.btnVD.UseVisualStyleBackColor = true;
            this.btnVD.Click += new System.EventHandler(this.btnVD_Click);
            // 
            // btnGC
            // 
            this.btnGC.FlatAppearance.BorderSize = 0;
            this.btnGC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(34)))), ((int)(((byte)(29)))));
            this.btnGC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGC.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGC.ForeColor = System.Drawing.Color.White;
            this.btnGC.Image = global::ProyectoPOO.Properties.Resources._3;
            this.btnGC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGC.Location = new System.Drawing.Point(0, 245);
            this.btnGC.Margin = new System.Windows.Forms.Padding(4);
            this.btnGC.Name = "btnGC";
            this.btnGC.Size = new System.Drawing.Size(269, 103);
            this.btnGC.TabIndex = 4;
            this.btnGC.Text = "Gasto Calórico";
            this.btnGC.UseVisualStyleBackColor = true;
            this.btnGC.Click += new System.EventHandler(this.btnGC_Click);
            // 
            // btnRFatiga
            // 
            this.btnRFatiga.FlatAppearance.BorderSize = 0;
            this.btnRFatiga.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(34)))), ((int)(((byte)(29)))));
            this.btnRFatiga.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRFatiga.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRFatiga.ForeColor = System.Drawing.Color.White;

            this.btnRFatiga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRFatiga.Location = new System.Drawing.Point(0, 107);
            this.btnRFatiga.Margin = new System.Windows.Forms.Padding(4);
            this.btnRFatiga.Name = "btnRFatiga";
            this.btnRFatiga.Size = new System.Drawing.Size(237, 89);
            this.btnRFatiga.TabIndex = 3;
            this.btnRFatiga.Text = "RIESGO POR FATIGA";
            this.btnRFatiga.UseVisualStyleBackColor = true;
            this.btnRFatiga.Click += new System.EventHandler(this.btnRFatiga_Click);
            // 
            // panelBienestarBackground
            // 
            this.panelBienestarBackground.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelBienestarBackground.Location = new System.Drawing.Point(241, 0);
            this.panelBienestarBackground.Name = "panelBienestarBackground";
            this.panelBienestarBackground.Size = new System.Drawing.Size(785, 787);
            this.panelBienestarBackground.TabIndex = 3;
            // 
            // ucBienestar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelBienestar);
            this.Controls.Add(this.panelBienestarBackground);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucBienestar";
            this.Size = new System.Drawing.Size(1026, 787);
            this.panelBienestar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMainBienestar;
        private System.Windows.Forms.Panel panelBienestar;
        private System.Windows.Forms.Panel panelBienestarBackground;
        private System.Windows.Forms.Button btnVD;
        private System.Windows.Forms.Button btnGC;
        private System.Windows.Forms.Button btnRFatiga;
    }
}
