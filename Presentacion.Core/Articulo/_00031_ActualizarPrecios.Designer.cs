namespace Presentacion.Core.Articulo
{
    partial class _00031_ActualizarPrecios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.RdbPrecio = new System.Windows.Forms.RadioButton();
            this.rdbPorcentaje = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nudValor = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbListaPrecio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.chkArticulo = new System.Windows.Forms.CheckBox();
            this.chkRubro = new System.Windows.Forms.CheckBox();
            this.chkMarca = new System.Windows.Forms.CheckBox();
            this.cmbRubro = new System.Windows.Forms.ComboBox();
            this.cmbMarca = new System.Windows.Forms.ComboBox();
            this.nudCodigoDesde = new System.Windows.Forms.NumericUpDown();
            this.nudCodigoHasta = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEjecutar = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoHasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 68);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(502, 4);
            this.pnlSeparador.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEjecutar,
            this.btnLimpiar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Size = new System.Drawing.Size(502, 68);
            this.toolStrip1.TabIndex = 4;
            // 
            // RdbPrecio
            // 
            this.RdbPrecio.AutoSize = true;
            this.RdbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbPrecio.Location = new System.Drawing.Point(317, 329);
            this.RdbPrecio.Name = "RdbPrecio";
            this.RdbPrecio.Size = new System.Drawing.Size(47, 20);
            this.RdbPrecio.TabIndex = 184;
            this.RdbPrecio.Text = "[ $ ]";
            this.RdbPrecio.UseVisualStyleBackColor = true;
            // 
            // rdbPorcentaje
            // 
            this.rdbPorcentaje.AutoSize = true;
            this.rdbPorcentaje.Checked = true;
            this.rdbPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPorcentaje.Location = new System.Drawing.Point(266, 329);
            this.rdbPorcentaje.Name = "rdbPorcentaje";
            this.rdbPorcentaje.Size = new System.Drawing.Size(52, 20);
            this.rdbPorcentaje.TabIndex = 183;
            this.rdbPorcentaje.TabStop = true;
            this.rdbPorcentaje.Text = "[ % ]";
            this.rdbPorcentaje.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(83, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 182;
            this.label2.Text = "Valor";
            // 
            // nudValor
            // 
            this.nudValor.DecimalPlaces = 2;
            this.nudValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudValor.Location = new System.Drawing.Point(129, 327);
            this.nudValor.Name = "nudValor";
            this.nudValor.Size = new System.Drawing.Size(120, 22);
            this.nudValor.TabIndex = 181;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(17, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 4);
            this.panel1.TabIndex = 180;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(26, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
            this.label10.TabIndex = 179;
            this.label10.Text = "Lista de Precio";
            // 
            // cmbListaPrecio
            // 
            this.cmbListaPrecio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbListaPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbListaPrecio.FormattingEnabled = true;
            this.cmbListaPrecio.Location = new System.Drawing.Point(129, 288);
            this.cmbListaPrecio.Name = "cmbListaPrecio";
            this.cmbListaPrecio.Size = new System.Drawing.Size(337, 24);
            this.cmbListaPrecio.TabIndex = 178;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(283, 213);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 177;
            this.label1.Text = "Codigo hasta";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(128, 212);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 16);
            this.label17.TabIndex = 175;
            this.label17.Text = "Codigo desde";
            // 
            // chkArticulo
            // 
            this.chkArticulo.AutoSize = true;
            this.chkArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkArticulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkArticulo.Location = new System.Drawing.Point(37, 232);
            this.chkArticulo.Name = "chkArticulo";
            this.chkArticulo.Size = new System.Drawing.Size(71, 20);
            this.chkArticulo.TabIndex = 173;
            this.chkArticulo.Text = "Articulo";
            this.chkArticulo.UseVisualStyleBackColor = true;
            // 
            // chkRubro
            // 
            this.chkRubro.AutoSize = true;
            this.chkRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkRubro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkRubro.Location = new System.Drawing.Point(37, 182);
            this.chkRubro.Name = "chkRubro";
            this.chkRubro.Size = new System.Drawing.Size(64, 20);
            this.chkRubro.TabIndex = 172;
            this.chkRubro.Text = "Rubro";
            this.chkRubro.UseVisualStyleBackColor = true;
            // 
            // chkMarca
            // 
            this.chkMarca.AutoSize = true;
            this.chkMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chkMarca.Location = new System.Drawing.Point(37, 154);
            this.chkMarca.Name = "chkMarca";
            this.chkMarca.Size = new System.Drawing.Size(65, 20);
            this.chkMarca.TabIndex = 171;
            this.chkMarca.Text = "Marca";
            this.chkMarca.UseVisualStyleBackColor = true;
            // 
            // cmbRubro
            // 
            this.cmbRubro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRubro.FormattingEnabled = true;
            this.cmbRubro.Location = new System.Drawing.Point(113, 180);
            this.cmbRubro.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRubro.Name = "cmbRubro";
            this.cmbRubro.Size = new System.Drawing.Size(337, 24);
            this.cmbRubro.TabIndex = 170;
            // 
            // cmbMarca
            // 
            this.cmbMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMarca.Location = new System.Drawing.Point(113, 152);
            this.cmbMarca.Margin = new System.Windows.Forms.Padding(2);
            this.cmbMarca.Name = "cmbMarca";
            this.cmbMarca.Size = new System.Drawing.Size(337, 24);
            this.cmbMarca.TabIndex = 169;
            // 
            // nudCodigoDesde
            // 
            this.nudCodigoDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCodigoDesde.Location = new System.Drawing.Point(116, 232);
            this.nudCodigoDesde.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nudCodigoDesde.Name = "nudCodigoDesde";
            this.nudCodigoDesde.Size = new System.Drawing.Size(120, 22);
            this.nudCodigoDesde.TabIndex = 185;
            // 
            // nudCodigoHasta
            // 
            this.nudCodigoHasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCodigoHasta.Location = new System.Drawing.Point(264, 232);
            this.nudCodigoHasta.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.nudCodigoHasta.Name = "nudCodigoHasta";
            this.nudCodigoHasta.Size = new System.Drawing.Size(120, 22);
            this.nudCodigoHasta.TabIndex = 186;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(17, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 4);
            this.panel2.TabIndex = 181;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(280, 102);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1569325056,
            23283064,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 188;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(113, 102);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(123, 22);
            this.dateTimePicker1.TabIndex = 189;
            this.dateTimePicker1.Value = new System.DateTime(2020, 11, 2, 17, 44, 50, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(50, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 190;
            this.label4.Text = "Fecha";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEjecutar.Image = global::Presentacion.Core.Properties.Resources.Nuevo;
            this.btnEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(53, 59);
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLimpiar.Image = global::Presentacion.Core.Properties.Resources.Limpiar;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(51, 59);
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Image = global::Presentacion.Core.Properties.Resources.Salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(44, 59);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // _00031_ActualizarPrecios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 361);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.nudCodigoHasta);
            this.Controls.Add(this.nudCodigoDesde);
            this.Controls.Add(this.RdbPrecio);
            this.Controls.Add(this.rdbPorcentaje);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudValor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbListaPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.chkArticulo);
            this.Controls.Add(this.chkRubro);
            this.Controls.Add(this.chkMarca);
            this.Controls.Add(this.cmbRubro);
            this.Controls.Add(this.cmbMarca);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(502, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(502, 400);
            this.Name = "_00031_ActualizarPrecios";
            this.Text = "Actualización de Precios";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudValor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCodigoHasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton btnEjecutar;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.RadioButton RdbPrecio;
        private System.Windows.Forms.RadioButton rdbPorcentaje;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudValor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbListaPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkArticulo;
        private System.Windows.Forms.CheckBox chkRubro;
        private System.Windows.Forms.CheckBox chkMarca;
        private System.Windows.Forms.ComboBox cmbRubro;
        private System.Windows.Forms.ComboBox cmbMarca;
        private System.Windows.Forms.NumericUpDown nudCodigoDesde;
        private System.Windows.Forms.NumericUpDown nudCodigoHasta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
    }
}