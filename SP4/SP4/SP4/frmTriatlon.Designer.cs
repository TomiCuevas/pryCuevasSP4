namespace SP4
{
    partial class frmTriatlon
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
            this.grpParticipantes = new System.Windows.Forms.GroupBox();
            this.dgvParticipantes = new System.Windows.Forms.DataGridView();
            this.ColumnNumero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPais2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAsignarParticipantes = new System.Windows.Forms.Button();
            this.btnDeterminarGanadores = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grpGanadores = new System.Windows.Forms.GroupBox();
            this.dgvPosiciones = new System.Windows.Forms.DataGridView();
            this.ColumnPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticipante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticipante2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticipante3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticipante4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticipante5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnParticipante6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpPosiciones = new System.Windows.Forms.GroupBox();
            this.dgvGanadores = new System.Windows.Forms.DataGridView();
            this.columnaPuestos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picGanadores = new System.Windows.Forms.PictureBox();
            this.grpParticipantes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).BeginInit();
            this.grpGanadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).BeginInit();
            this.grpPosiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).BeginInit();
            this.SuspendLayout();
            // 
            // grpParticipantes
            // 
            this.grpParticipantes.Controls.Add(this.dgvParticipantes);
            this.grpParticipantes.Location = new System.Drawing.Point(12, 12);
            this.grpParticipantes.Name = "grpParticipantes";
            this.grpParticipantes.Size = new System.Drawing.Size(785, 292);
            this.grpParticipantes.TabIndex = 13;
            this.grpParticipantes.TabStop = false;
            this.grpParticipantes.Text = "Participantes";
            // 
            // dgvParticipantes
            // 
            this.dgvParticipantes.AllowUserToAddRows = false;
            this.dgvParticipantes.AllowUserToDeleteRows = false;
            this.dgvParticipantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParticipantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNumero,
            this.ColumnNombre2,
            this.ColumnPais2});
            this.dgvParticipantes.Location = new System.Drawing.Point(6, 21);
            this.dgvParticipantes.Name = "dgvParticipantes";
            this.dgvParticipantes.RowHeadersWidth = 51;
            this.dgvParticipantes.RowTemplate.Height = 24;
            this.dgvParticipantes.Size = new System.Drawing.Size(652, 232);
            this.dgvParticipantes.TabIndex = 2;
            // 
            // ColumnNumero
            // 
            this.ColumnNumero.HeaderText = "Número";
            this.ColumnNumero.MinimumWidth = 6;
            this.ColumnNumero.Name = "ColumnNumero";
            this.ColumnNumero.Width = 125;
            // 
            // ColumnNombre2
            // 
            this.ColumnNombre2.HeaderText = "Nombre";
            this.ColumnNombre2.MinimumWidth = 6;
            this.ColumnNombre2.Name = "ColumnNombre2";
            this.ColumnNombre2.Width = 125;
            // 
            // ColumnPais2
            // 
            this.ColumnPais2.HeaderText = "País";
            this.ColumnPais2.MinimumWidth = 6;
            this.ColumnPais2.Name = "ColumnPais2";
            this.ColumnPais2.Width = 125;
            // 
            // btnAsignarParticipantes
            // 
            this.btnAsignarParticipantes.Location = new System.Drawing.Point(826, 42);
            this.btnAsignarParticipantes.Name = "btnAsignarParticipantes";
            this.btnAsignarParticipantes.Size = new System.Drawing.Size(153, 54);
            this.btnAsignarParticipantes.TabIndex = 5;
            this.btnAsignarParticipantes.Text = "Asignar Participantes";
            this.btnAsignarParticipantes.UseVisualStyleBackColor = true;
            this.btnAsignarParticipantes.Click += new System.EventHandler(this.btnAsignarParticipantes_Click);
            // 
            // btnDeterminarGanadores
            // 
            this.btnDeterminarGanadores.Location = new System.Drawing.Point(826, 112);
            this.btnDeterminarGanadores.Name = "btnDeterminarGanadores";
            this.btnDeterminarGanadores.Size = new System.Drawing.Size(155, 50);
            this.btnDeterminarGanadores.TabIndex = 14;
            this.btnDeterminarGanadores.Text = "Determinar Ganadores";
            this.btnDeterminarGanadores.UseVisualStyleBackColor = true;
            this.btnDeterminarGanadores.Click += new System.EventHandler(this.btnDeterminarGanadores_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(826, 179);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(155, 52);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // grpGanadores
            // 
            this.grpGanadores.Controls.Add(this.dgvPosiciones);
            this.grpGanadores.Location = new System.Drawing.Point(12, 310);
            this.grpGanadores.Name = "grpGanadores";
            this.grpGanadores.Size = new System.Drawing.Size(1272, 227);
            this.grpGanadores.TabIndex = 16;
            this.grpGanadores.TabStop = false;
            this.grpGanadores.Text = "Ganadores";
            // 
            // dgvPosiciones
            // 
            this.dgvPosiciones.AllowUserToAddRows = false;
            this.dgvPosiciones.AllowUserToDeleteRows = false;
            this.dgvPosiciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosiciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPrueba,
            this.ColumnParticipante,
            this.ColumnParticipante2,
            this.ColumnParticipante3,
            this.ColumnParticipante4,
            this.ColumnParticipante5,
            this.ColumnParticipante6});
            this.dgvPosiciones.Location = new System.Drawing.Point(15, 21);
            this.dgvPosiciones.Name = "dgvPosiciones";
            this.dgvPosiciones.RowHeadersWidth = 51;
            this.dgvPosiciones.RowTemplate.Height = 24;
            this.dgvPosiciones.Size = new System.Drawing.Size(1242, 177);
            this.dgvPosiciones.TabIndex = 8;
            // 
            // ColumnPrueba
            // 
            this.ColumnPrueba.HeaderText = "Prueba ";
            this.ColumnPrueba.MinimumWidth = 6;
            this.ColumnPrueba.Name = "ColumnPrueba";
            this.ColumnPrueba.Width = 125;
            // 
            // ColumnParticipante
            // 
            this.ColumnParticipante.HeaderText = "Participante 1";
            this.ColumnParticipante.MinimumWidth = 6;
            this.ColumnParticipante.Name = "ColumnParticipante";
            this.ColumnParticipante.Width = 125;
            // 
            // ColumnParticipante2
            // 
            this.ColumnParticipante2.HeaderText = "Participante 2";
            this.ColumnParticipante2.MinimumWidth = 6;
            this.ColumnParticipante2.Name = "ColumnParticipante2";
            this.ColumnParticipante2.Width = 125;
            // 
            // ColumnParticipante3
            // 
            this.ColumnParticipante3.HeaderText = "Participante 3";
            this.ColumnParticipante3.MinimumWidth = 6;
            this.ColumnParticipante3.Name = "ColumnParticipante3";
            this.ColumnParticipante3.Width = 125;
            // 
            // ColumnParticipante4
            // 
            this.ColumnParticipante4.HeaderText = "Participante 4";
            this.ColumnParticipante4.MinimumWidth = 6;
            this.ColumnParticipante4.Name = "ColumnParticipante4";
            this.ColumnParticipante4.Width = 125;
            // 
            // ColumnParticipante5
            // 
            this.ColumnParticipante5.HeaderText = "Participante 5";
            this.ColumnParticipante5.MinimumWidth = 6;
            this.ColumnParticipante5.Name = "ColumnParticipante5";
            this.ColumnParticipante5.Width = 125;
            // 
            // ColumnParticipante6
            // 
            this.ColumnParticipante6.HeaderText = "Participante 6";
            this.ColumnParticipante6.MinimumWidth = 6;
            this.ColumnParticipante6.Name = "ColumnParticipante6";
            this.ColumnParticipante6.Width = 125;
            // 
            // grpPosiciones
            // 
            this.grpPosiciones.Controls.Add(this.dgvGanadores);
            this.grpPosiciones.Location = new System.Drawing.Point(12, 543);
            this.grpPosiciones.Name = "grpPosiciones";
            this.grpPosiciones.Size = new System.Drawing.Size(856, 176);
            this.grpPosiciones.TabIndex = 12;
            this.grpPosiciones.TabStop = false;
            this.grpPosiciones.Text = "Posiciones";
            // 
            // dgvGanadores
            // 
            this.dgvGanadores.AllowUserToAddRows = false;
            this.dgvGanadores.AllowUserToDeleteRows = false;
            this.dgvGanadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGanadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaPuestos,
            this.ColumnNombre,
            this.ColumnPais,
            this.ColumnPuntos});
            this.dgvGanadores.Location = new System.Drawing.Point(24, 21);
            this.dgvGanadores.Name = "dgvGanadores";
            this.dgvGanadores.ReadOnly = true;
            this.dgvGanadores.RowHeadersWidth = 51;
            this.dgvGanadores.RowTemplate.Height = 24;
            this.dgvGanadores.Size = new System.Drawing.Size(812, 142);
            this.dgvGanadores.TabIndex = 8;
            // 
            // columnaPuestos
            // 
            this.columnaPuestos.HeaderText = "Puestos";
            this.columnaPuestos.MinimumWidth = 6;
            this.columnaPuestos.Name = "columnaPuestos";
            this.columnaPuestos.ReadOnly = true;
            this.columnaPuestos.Width = 125;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 6;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 125;
            // 
            // ColumnPais
            // 
            this.ColumnPais.HeaderText = "PAÍS";
            this.ColumnPais.MinimumWidth = 6;
            this.ColumnPais.Name = "ColumnPais";
            this.ColumnPais.ReadOnly = true;
            this.ColumnPais.Width = 125;
            // 
            // ColumnPuntos
            // 
            this.ColumnPuntos.HeaderText = "Puntos";
            this.ColumnPuntos.MinimumWidth = 6;
            this.ColumnPuntos.Name = "ColumnPuntos";
            this.ColumnPuntos.ReadOnly = true;
            this.ColumnPuntos.Width = 125;
            // 
            // picGanadores
            // 
            this.picGanadores.Image = global::SP4.Properties.Resources.PODIO11;
            this.picGanadores.Location = new System.Drawing.Point(947, 543);
            this.picGanadores.Name = "picGanadores";
            this.picGanadores.Size = new System.Drawing.Size(263, 205);
            this.picGanadores.TabIndex = 17;
            this.picGanadores.TabStop = false;
            this.picGanadores.Click += new System.EventHandler(this.picGanadores_Click);
            // 
            // frmTriatlon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1297, 741);
            this.Controls.Add(this.picGanadores);
            this.Controls.Add(this.grpPosiciones);
            this.Controls.Add(this.grpGanadores);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeterminarGanadores);
            this.Controls.Add(this.btnAsignarParticipantes);
            this.Controls.Add(this.grpParticipantes);
            this.Name = "frmTriatlon";
            this.Text = "TRIATLÓN";
            this.Load += new System.EventHandler(this.frmTriatlon_Load);
            this.grpParticipantes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParticipantes)).EndInit();
            this.grpGanadores.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosiciones)).EndInit();
            this.grpPosiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGanadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGanadores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpParticipantes;
        private System.Windows.Forms.DataGridView dgvParticipantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPais2;
        private System.Windows.Forms.Button btnAsignarParticipantes;
        private System.Windows.Forms.Button btnDeterminarGanadores;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.GroupBox grpGanadores;
        private System.Windows.Forms.DataGridView dgvPosiciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticipante;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticipante2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticipante3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticipante4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticipante5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnParticipante6;
        private System.Windows.Forms.GroupBox grpPosiciones;
        private System.Windows.Forms.DataGridView dgvGanadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaPuestos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPais;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPuntos;
        private System.Windows.Forms.PictureBox picGanadores;
    }
}

