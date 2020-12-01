namespace Presentacion.Core.FormaPago
{
    partial class _00049_CobroDiferido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_00049_CobroDiferido));
            this.pnlSeparador = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnEjecutar = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTotales = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvGrillaDetalleComprobante = new System.Windows.Forms.DataGridView();
            this.dgvGrillaPedientePago = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDetalleComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaPedientePago)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSeparador
            // 
            this.pnlSeparador.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pnlSeparador.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador.Location = new System.Drawing.Point(0, 58);
            this.pnlSeparador.Name = "pnlSeparador";
            this.pnlSeparador.Size = new System.Drawing.Size(784, 4);
            this.pnlSeparador.TabIndex = 5;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEjecutar,
            this.btnSalir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(3);
            this.toolStrip1.Size = new System.Drawing.Size(784, 58);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEjecutar.Image = ((System.Drawing.Image)(resources.GetObject("btnEjecutar.Image")));
            this.btnEjecutar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(53, 49);
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnSalir
            // 
            this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSalir.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(34, 49);
            this.btnSalir.Text = "Salir";
            this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 62);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.dgvGrillaPedientePago);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.White;
            this.splitContainer1.Panel2.Controls.Add(this.dgvGrillaDetalleComprobante);
            this.splitContainer1.Panel2.Controls.Add(this.panel2);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.pnlTotales);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 499);
            this.splitContainer1.SplitterDistance = 454;
            this.splitContainer1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Comprobantes pendientes de Pago";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(326, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Detalle del Comprobante";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlTotales
            // 
            this.pnlTotales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlTotales.Controls.Add(this.label11);
            this.pnlTotales.Controls.Add(this.nudTotal);
            this.pnlTotales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotales.Location = new System.Drawing.Point(0, 452);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(326, 47);
            this.pnlTotales.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(16, 13);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 25);
            this.label11.TabIndex = 37;
            this.label11.Text = "TOTAL";
            // 
            // nudTotal
            // 
            this.nudTotal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.nudTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudTotal.DecimalPlaces = 2;
            this.nudTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTotal.ForeColor = System.Drawing.Color.Black;
            this.nudTotal.Increment = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.nudTotal.Location = new System.Drawing.Point(106, 9);
            this.nudTotal.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(208, 31);
            this.nudTotal.TabIndex = 36;
            this.nudTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(326, 4);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 39);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 4);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 4);
            this.panel3.TabIndex = 8;
            // 
            // dgvGrillaDetalleComprobante
            // 
            this.dgvGrillaDetalleComprobante.AllowUserToAddRows = false;
            this.dgvGrillaDetalleComprobante.AllowUserToDeleteRows = false;
            this.dgvGrillaDetalleComprobante.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrillaDetalleComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaDetalleComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrillaDetalleComprobante.Location = new System.Drawing.Point(0, 43);
            this.dgvGrillaDetalleComprobante.MultiSelect = false;
            this.dgvGrillaDetalleComprobante.Name = "dgvGrillaDetalleComprobante";
            this.dgvGrillaDetalleComprobante.ReadOnly = true;
            this.dgvGrillaDetalleComprobante.RowHeadersVisible = false;
            this.dgvGrillaDetalleComprobante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrillaDetalleComprobante.Size = new System.Drawing.Size(326, 405);
            this.dgvGrillaDetalleComprobante.TabIndex = 8;
            // 
            // dgvGrillaPedientePago
            // 
            this.dgvGrillaPedientePago.AllowUserToAddRows = false;
            this.dgvGrillaPedientePago.AllowUserToDeleteRows = false;
            this.dgvGrillaPedientePago.BackgroundColor = System.Drawing.Color.White;
            this.dgvGrillaPedientePago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrillaPedientePago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvGrillaPedientePago.Location = new System.Drawing.Point(0, 43);
            this.dgvGrillaPedientePago.MultiSelect = false;
            this.dgvGrillaPedientePago.Name = "dgvGrillaPedientePago";
            this.dgvGrillaPedientePago.ReadOnly = true;
            this.dgvGrillaPedientePago.RowHeadersVisible = false;
            this.dgvGrillaPedientePago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrillaPedientePago.Size = new System.Drawing.Size(454, 456);
            this.dgvGrillaPedientePago.TabIndex = 9;
            // 
            // _00049_CobroDiferido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.pnlSeparador);
            this.Controls.Add(this.toolStrip1);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "_00049_CobroDiferido";
            this.Text = "Cobro Diferido";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlTotales.ResumeLayout(false);
            this.pnlTotales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaDetalleComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrillaPedientePago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSeparador;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton btnEjecutar;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlTotales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.DataGridView dgvGrillaPedientePago;
        private System.Windows.Forms.DataGridView dgvGrillaDetalleComprobante;
    }
}