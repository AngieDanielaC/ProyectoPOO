namespace ProyectoPOO
{
    partial class ucBGastoC
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
            this.dgvGastoC = new System.Windows.Forms.DataGridView();
            this.colGC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGC4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGC5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGC6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGC7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegisBR = new System.Windows.Forms.Button();
            this.txbPeso = new System.Windows.Forms.TextBox();
            this.lblduracion = new System.Windows.Forms.Label();
            this.lblRecibidoIJ = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecibidoNv = new System.Windows.Forms.Label();
            this.txtbpeso = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lblBVR = new System.Windows.Forms.Label();
            this.panelGastoC.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastoC)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGastoC
            // 
            this.panelGastoC.BackColor = System.Drawing.Color.White;
            this.panelGastoC.Controls.Add(this.dgvGastoC);
            this.panelGastoC.Controls.Add(this.btnRegisBR);
            this.panelGastoC.Controls.Add(this.txbPeso);
            this.panelGastoC.Controls.Add(this.lblduracion);
            this.panelGastoC.Controls.Add(this.lblRecibidoIJ);
            this.panelGastoC.Controls.Add(this.label3);
            this.panelGastoC.Controls.Add(this.lblRecibidoNv);
            this.panelGastoC.Controls.Add(this.txtbpeso);
            this.panelGastoC.Controls.Add(this.label2);
            this.panelGastoC.Controls.Add(this.lblKG);
            this.panelGastoC.Controls.Add(this.cmbSelect);
            this.panelGastoC.Controls.Add(this.lblBVR);
            this.panelGastoC.Location = new System.Drawing.Point(0, 0);
            this.panelGastoC.Name = "panelGastoC";
            this.panelGastoC.Size = new System.Drawing.Size(1021, 727);
            this.panelGastoC.TabIndex = 1;
            // 
            // dgvGastoC
            // 
            this.dgvGastoC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGastoC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colGC1,
            this.colGC2,
            this.colGC3,
            this.colGC4,
            this.colGC5,
            this.colGC6,
            this.colGC7});
            this.dgvGastoC.Location = new System.Drawing.Point(61, 178);
            this.dgvGastoC.Name = "dgvGastoC";
            this.dgvGastoC.RowHeadersWidth = 51;
            this.dgvGastoC.RowTemplate.Height = 24;
            this.dgvGastoC.Size = new System.Drawing.Size(908, 512);
            this.dgvGastoC.TabIndex = 12;
            // 
            // colGC1
            // 
            this.colGC1.HeaderText = "DEPORTISTA";
            this.colGC1.MinimumWidth = 6;
            this.colGC1.Name = "colGC1";
            this.colGC1.Width = 125;
            // 
            // colGC2
            // 
            this.colGC2.HeaderText = "PESO";
            this.colGC2.MinimumWidth = 6;
            this.colGC2.Name = "colGC2";
            this.colGC2.Width = 125;
            // 
            // colGC3
            // 
            this.colGC3.HeaderText = "ENERGÍA";
            this.colGC3.MinimumWidth = 6;
            this.colGC3.Name = "colGC3";
            this.colGC3.Width = 125;
            // 
            // colGC4
            // 
            this.colGC4.HeaderText = "INTENSIDAD";
            this.colGC4.MinimumWidth = 6;
            this.colGC4.Name = "colGC4";
            this.colGC4.Width = 125;
            // 
            // colGC5
            // 
            this.colGC5.HeaderText = "DURACIÓN DEL ENTRENAMIENTO";
            this.colGC5.MinimumWidth = 6;
            this.colGC5.Name = "colGC5";
            this.colGC5.Width = 125;
            // 
            // colGC6
            // 
            this.colGC6.HeaderText = "GASTO CALORICO";
            this.colGC6.MinimumWidth = 6;
            this.colGC6.Name = "colGC6";
            this.colGC6.Width = 125;
            // 
            // colGC7
            // 
            this.colGC7.HeaderText = "DEFICIT ENERGETICO";
            this.colGC7.MinimumWidth = 6;
            this.colGC7.Name = "colGC7";
            this.colGC7.Width = 125;
            // 
            // btnRegisBR
            // 
            this.btnRegisBR.Location = new System.Drawing.Point(7, 132);
            this.btnRegisBR.Name = "btnRegisBR";
            this.btnRegisBR.Size = new System.Drawing.Size(189, 40);
            this.btnRegisBR.TabIndex = 11;
            this.btnRegisBR.Text = "REGISTRAR";
            this.btnRegisBR.UseVisualStyleBackColor = true;
            // 
            // txbPeso
            // 
            this.txbPeso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPeso.Location = new System.Drawing.Point(691, 28);
            this.txbPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txbPeso.Name = "txbPeso";
            this.txbPeso.Size = new System.Drawing.Size(298, 32);
            this.txbPeso.TabIndex = 10;
            // 
            // lblduracion
            // 
            this.lblduracion.AutoSize = true;
            this.lblduracion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblduracion.Location = new System.Drawing.Point(686, 0);
            this.lblduracion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblduracion.Name = "lblduracion";
            this.lblduracion.Size = new System.Drawing.Size(303, 27);
            this.lblduracion.TabIndex = 9;
            this.lblduracion.Text = "PESO DEL DEPORTISTA (KG)";
            // 
            // lblRecibidoIJ
            // 
            this.lblRecibidoIJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(229)))));
            this.lblRecibidoIJ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecibidoIJ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecibidoIJ.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibidoIJ.Location = new System.Drawing.Point(7, 102);
            this.lblRecibidoIJ.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecibidoIJ.Name = "lblRecibidoIJ";
            this.lblRecibidoIJ.Size = new System.Drawing.Size(439, 27);
            this.lblRecibidoIJ.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(444, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "INTENSIDAD DEL EJERCICIO REPORTADO";
            // 
            // lblRecibidoNv
            // 
            this.lblRecibidoNv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(212)))), ((int)(((byte)(229)))));
            this.lblRecibidoNv.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRecibidoNv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblRecibidoNv.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecibidoNv.Location = new System.Drawing.Point(467, 102);
            this.lblRecibidoNv.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecibidoNv.Name = "lblRecibidoNv";
            this.lblRecibidoNv.Size = new System.Drawing.Size(347, 27);
            this.lblRecibidoNv.TabIndex = 6;
            // 
            // txtbpeso
            // 
            this.txtbpeso.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbpeso.Location = new System.Drawing.Point(298, 29);
            this.txtbpeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtbpeso.Name = "txtbpeso";
            this.txtbpeso.Size = new System.Drawing.Size(361, 32);
            this.txtbpeso.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(462, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(347, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "NIVEL DE ENERGÍA REPORTADO";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKG.Location = new System.Drawing.Point(293, 0);
            this.lblKG.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(366, 27);
            this.lblKG.TabIndex = 3;
            this.lblKG.Text = "DURACIÓN DEL ENTRENAMIENTO";
            // 
            // cmbSelect
            // 
            this.cmbSelect.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(7, 29);
            this.cmbSelect.Margin = new System.Windows.Forms.Padding(2);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(259, 31);
            this.cmbSelect.TabIndex = 2;
            // 
            // lblBVR
            // 
            this.lblBVR.AutoSize = true;
            this.lblBVR.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBVR.Location = new System.Drawing.Point(2, 0);
            this.lblBVR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBVR.Name = "lblBVR";
            this.lblBVR.Size = new System.Drawing.Size(264, 27);
            this.lblBVR.TabIndex = 1;
            this.lblBVR.Text = "SELECIONE DEPORTISTA";
            // 
            // ucBGastoC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelGastoC);
            this.Name = "ucBGastoC";
            this.Size = new System.Drawing.Size(1021, 727);
            this.panelGastoC.ResumeLayout(false);
            this.panelGastoC.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGastoC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGastoC;
        private System.Windows.Forms.DataGridView dgvGastoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGC7;
        private System.Windows.Forms.Button btnRegisBR;
        private System.Windows.Forms.TextBox txbPeso;
        private System.Windows.Forms.Label lblduracion;
        private System.Windows.Forms.Label lblRecibidoIJ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecibidoNv;
        private System.Windows.Forms.TextBox txtbpeso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKG;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label lblBVR;
    }
}
