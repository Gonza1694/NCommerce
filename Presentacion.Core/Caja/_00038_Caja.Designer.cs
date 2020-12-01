namespace Presentacion.Core.Caja
{
    partial class _00038_Caja
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
            this.dgvGrilla = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlBusqueda = new System.Windows.Forms.Panel();
            this.dtp_hasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_desde = new System.Windows.Forms.DateTimePicker();
            this.chk_rangofecha = new System.Windows.Forms.CheckBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAbrirCaja = new System.Windows.Forms.ToolStripButton();
            this.btnCierreCaja = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
            this.pnlBusqueda.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGrilla
            // 
            this.dgvGrilla.AllowUserToAddRows = false;
            this.dgvGrilla.AllowUserToDeleteRows = false;
            this.dgvGrilla.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrilla.Location = new System.Drawing.Point(0, 117);
            this.dgvGrilla.MultiSelect = false;
            this.dgvGrilla.Name = "dgvGrilla";
            this.dgvGrilla.ReadOnly = true;
            this.dgvGrilla.RowHeadersVisible = false;
            this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrilla.Size = new System.Drawing.Size(800, 311);
            this.dgvGrilla.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // pnlBusqueda
            // 
            this.pnlBusqueda.BackColor = System.Drawing.Color.Gray;
            this.pnlBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBusqueda.Controls.Add(this.dtp_hasta);
            this.pnlBusqueda.Controls.Add(this.dtp_desde);
            this.pnlBusqueda.Controls.Add(this.chk_rangofecha);
            this.pnlBusqueda.Controls.Add(this.txtBuscar);
            this.pnlBusqueda.Controls.Add(this.btnBuscar);
            this.pnlBusqueda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBusqueda.Location = new System.Drawing.Point(0, 74);
            this.pnlBusqueda.Name = "pnlBusqueda";
            this.pnlBusqueda.Size = new System.Drawing.Size(800, 43);
            this.pnlBusqueda.TabIndex = 8;
            // 
            // dtp_hasta
            // 
            this.dtp_hasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_hasta.Location = new System.Drawing.Point(310, 12);
            this.dtp_hasta.Name = "dtp_hasta";
            this.dtp_hasta.Size = new System.Drawing.Size(96, 20);
            this.dtp_hasta.TabIndex = 4;
            // 
            // dtp_desde
            // 
            this.dtp_desde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_desde.Location = new System.Drawing.Point(198, 12);
            this.dtp_desde.Name = "dtp_desde";
            this.dtp_desde.Size = new System.Drawing.Size(96, 20);
            this.dtp_desde.TabIndex = 3;
            // 
            // chk_rangofecha
            // 
            this.chk_rangofecha.AutoSize = true;
            this.chk_rangofecha.Location = new System.Drawing.Point(175, 15);
            this.chk_rangofecha.Name = "chk_rangofecha";
            this.chk_rangofecha.Size = new System.Drawing.Size(15, 14);
            this.chk_rangofecha.TabIndex = 2;
            this.chk_rangofecha.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuscar.Location = new System.Drawing.Point(420, 12);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(279, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBuscar.BackColor = System.Drawing.Color.DimGray;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnBuscar.Location = new System.Drawing.Point(714, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(145)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 69);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(800, 5);
            this.pnlSeparador.TabIndex = 7;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(88)))), ((int)(((byte)(122)))));
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAbrirCaja,
            this.btnCierreCaja,
            this.toolStripSeparator1,
            this.btnActualizar,
            this.btnSalir});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Size = new System.Drawing.Size(800, 69);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAbrirCaja
            // 
            this.btnAbrirCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbrirCaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAbrirCaja.Image = global::Presentacion.Core.Properties.Resources.caja_registradora;
            this.btnAbrirCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAbrirCaja.Name = "btnAbrirCaja";
            this.btnAbrirCaja.Size = new System.Drawing.Size(109, 50);
            this.btnAbrirCaja.Text = "Apertura de Caja";
            this.btnAbrirCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAbrirCaja.Click += new System.EventHandler(this.btnAbrirCaja_Click);
            // 
            // btnCierreCaja
            // 
            this.btnCierreCaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCierreCaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCierreCaja.Image = global::Presentacion.Core.Properties.Resources.close_rectangular_commercial_signal;
            this.btnCierreCaja.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCierreCaja.Name = "btnCierreCaja";
            this.btnCierreCaja.Size = new System.Drawing.Size(94, 50);
            this.btnCierreCaja.Text = "Cierre de Caja";
            this.btnCierreCaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCierreCaja.Click += new System.EventHandler(this.btnCierreCaja_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActualizar.Image = global::Presentacion.Core.Properties.Resources.circular_arrows_couple;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(70, 50);
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnActualizar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Image = global::Presentacion.Core.Properties.Resources.Salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(38, 50);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // _00038_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGrilla);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlBusqueda);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "_00038_Caja";
            this.Text = "Apertura y Cierre de Cajas";
            this.Load += new System.EventHandler(this._00038_Caja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
            this.pnlBusqueda.ResumeLayout(false);
            this.pnlBusqueda.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrilla;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel pnlBusqueda;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton btnAbrirCaja;
        protected System.Windows.Forms.ToolStripButton btnCierreCaja;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        protected System.Windows.Forms.ToolStripButton btnActualizar;
        protected System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.DateTimePicker dtp_hasta;
        private System.Windows.Forms.DateTimePicker dtp_desde;
        private System.Windows.Forms.CheckBox chk_rangofecha;
    }
}