namespace ProyectoPOO
{
    partial class ucBVRe
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
            this.panelGastoC = new System.Windows.Forms.Panel();
            this.dgvBVRe = new System.Windows.Forms.DataGridView();
            this.colBVR1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBVR2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBVR3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBVR4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBVR5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelGastoC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBVRe)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGastoC
            // 
            this.panelGastoC.BackColor = System.Drawing.Color.White;
            this.panelGastoC.Controls.Add(this.dgvBVRe);
            this.panelGastoC.Location = new System.Drawing.Point(3, 34);
            this.panelGastoC.Name = "panelGastoC";
            this.panelGastoC.Size = new System.Drawing.Size(1018, 693);
            this.panelGastoC.TabIndex = 0;
            // 
            // dgvBVRe
            // 
            this.dgvBVRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBVRe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colBVR1,
            this.colBVR2,
            this.colBVR3,
            this.colBVR4,
            this.colBVR5});
            this.dgvBVRe.Location = new System.Drawing.Point(3, 3);
            this.dgvBVRe.Name = "dgvBVRe";
            this.dgvBVRe.RowHeadersWidth = 51;
            this.dgvBVRe.RowTemplate.Height = 24;
            this.dgvBVRe.Size = new System.Drawing.Size(680, 598);
            this.dgvBVRe.TabIndex = 0;
            // 
            // colBVR1
            // 
            this.colBVR1.HeaderText = "DEPORTISTA";
            this.colBVR1.MinimumWidth = 6;
            this.colBVR1.Name = "colBVR1";
            this.colBVR1.Width = 125;
            // 
            // colBVR2
            // 
            this.colBVR2.HeaderText = "GASTO CALORICO";
            this.colBVR2.MinimumWidth = 6;
            this.colBVR2.Name = "colBVR2";
            this.colBVR2.Width = 125;
            // 
            // colBVR3
            // 
            this.colBVR3.HeaderText = "RIESGO DE LESIÓN";
            this.colBVR3.MinimumWidth = 6;
            this.colBVR3.Name = "colBVR3";
            this.colBVR3.Width = 125;
            // 
            // colBVR4
            // 
            this.colBVR4.HeaderText = "RECUPERACIÓN ESTIMADA";
            this.colBVR4.MinimumWidth = 6;
            this.colBVR4.Name = "colBVR4";
            this.colBVR4.Width = 125;
            // 
            // colBVR5
            // 
            this.colBVR5.HeaderText = "PESO (KG)";
            this.colBVR5.MinimumWidth = 6;
            this.colBVR5.Name = "colBVR5";
            this.colBVR5.Width = 125;
            // 
            // ucBVRe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(237)))));
            this.Controls.Add(this.panelGastoC);
            this.Name = "ucBVRe";
            this.Size = new System.Drawing.Size(1021, 727);
            this.panelGastoC.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBVRe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGastoC;
        private System.Windows.Forms.DataGridView dgvBVRe;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBVR1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBVR2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBVR3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBVR4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBVR5;
    }
}
