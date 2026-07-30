namespace ProyectoPOO
{
    partial class ucVerTodasLasCompetencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.regresar = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtBuscarComp = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ccompetencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cResultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPosicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cparticipantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.regresar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(7)))), ((int)(((byte)(59)))));
            this.label1.Location = new System.Drawing.Point(78, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Historial de Competencias";
            // 
            // regresar
            // 
            this.regresar.Image = global::ProyectoPOO.Properties.Resources.icVolver;
            this.regresar.Location = new System.Drawing.Point(16, 48);
            this.regresar.Name = "regresar";
            this.regresar.Size = new System.Drawing.Size(56, 48);
            this.regresar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regresar.TabIndex = 7;
            this.regresar.TabStop = false;
            this.regresar.Click += new System.EventHandler(this.regresar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(80, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Consulta las competencias registradas del deportista.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ProyectoPOO.Properties.Resources.comp51;
            this.pictureBox2.Location = new System.Drawing.Point(16, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1012, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ProyectoPOO.Properties.Resources.comp51;
            this.pictureBox3.Location = new System.Drawing.Point(16, 204);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1012, 530);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // txtBuscarComp
            // 
            this.txtBuscarComp.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarComp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.txtBuscarComp.Location = new System.Drawing.Point(48, 249);
            this.txtBuscarComp.Name = "txtBuscarComp";
            this.txtBuscarComp.Size = new System.Drawing.Size(251, 27);
            this.txtBuscarComp.TabIndex = 12;
            this.txtBuscarComp.Text = "Buscar Competencia";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(414, 247);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 29);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(572, 249);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(191, 29);
            this.comboBox2.TabIndex = 17;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cfecha,
            this.ccompetencia,
            this.cResultado,
            this.cPosicion,
            this.cparticipantes});
            this.dataGridView1.Location = new System.Drawing.Point(195, 336);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 277);
            this.dataGridView1.TabIndex = 23;
            // 
            // cfecha
            // 
            this.cfecha.HeaderText = "Fecha";
            this.cfecha.Name = "cfecha";
            // 
            // ccompetencia
            // 
            this.ccompetencia.HeaderText = "Competencia";
            this.ccompetencia.Name = "ccompetencia";
            this.ccompetencia.Width = 150;
            // 
            // cResultado
            // 
            this.cResultado.HeaderText = "Resultado";
            this.cResultado.Name = "cResultado";
            // 
            // cPosicion
            // 
            this.cPosicion.HeaderText = "Posición";
            this.cPosicion.Name = "cPosicion";
            // 
            // cparticipantes
            // 
            this.cparticipantes.HeaderText = "Participantes";
            this.cparticipantes.Name = "cparticipantes";
            this.cparticipantes.Width = 150;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.label3.Location = new System.Drawing.Point(427, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 24;
            this.label3.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(88)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.label4.Location = new System.Drawing.Point(581, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 18);
            this.label4.TabIndex = 25;
            this.label4.Text = "Categoria:";
            // 
            // ucVerTodasLasCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtBuscarComp);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regresar);
            this.Name = "ucVerTodasLasCompetencias";
            this.Size = new System.Drawing.Size(1042, 787);
            ((System.ComponentModel.ISupportInitialize)(this.regresar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox regresar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox txtBuscarComp;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn ccompetencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cResultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPosicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cparticipantes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
