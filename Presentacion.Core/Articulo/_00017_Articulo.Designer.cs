namespace Presentacion.Core.Articulo
{
    partial class _00017_Articulo
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvPrecios = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.pnlTotalStock = new System.Windows.Forms.Panel();
            this.nudStockActual = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlFoto = new System.Windows.Forms.Panel();
            this.lblFoto = new System.Windows.Forms.Label();
            this.imgFoto = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtRubro = new System.Windows.Forms.TextBox();
            this.txtUnidad = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlDetalle.SuspendLayout();
            this.tabPageDetalle.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.pnlTotalStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).BeginInit();
            this.pnlFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlDetalle
            // 
            this.tabControlDetalle.Controls.Add(this.tabPage1);
            this.tabControlDetalle.Controls.Add(this.tabPage2);
            this.tabControlDetalle.Size = new System.Drawing.Size(316, 394);
            this.tabControlDetalle.Controls.SetChildIndex(this.tabPage2, 0);
            this.tabControlDetalle.Controls.SetChildIndex(this.tabPage1, 0);
            this.tabControlDetalle.Controls.SetChildIndex(this.tabPageDetalle, 0);
            // 
            // tabPageDetalle
            // 
            this.tabPageDetalle.Controls.Add(this.txtUbicacion);
            this.tabPageDetalle.Controls.Add(this.label3);
            this.tabPageDetalle.Controls.Add(this.txtIva);
            this.tabPageDetalle.Controls.Add(this.label2);
            this.tabPageDetalle.Controls.Add(this.txtUnidad);
            this.tabPageDetalle.Controls.Add(this.txtRubro);
            this.tabPageDetalle.Controls.Add(this.txtMarca);
            this.tabPageDetalle.Controls.Add(this.label6);
            this.tabPageDetalle.Controls.Add(this.label21);
            this.tabPageDetalle.Controls.Add(this.lblMarca);
            this.tabPageDetalle.Controls.Add(this.pnlFoto);
            this.tabPageDetalle.Size = new System.Drawing.Size(308, 368);
            this.tabPageDetalle.Text = "Datos Adicionales";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvPrecios);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(275, 313);
            this.tabPage1.TabIndex = 1;
            this.tabPage1.Text = "Lista de Precios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvPrecios
            // 
            this.dgvPrecios.AllowUserToAddRows = false;
            this.dgvPrecios.AllowUserToDeleteRows = false;
            this.dgvPrecios.BackgroundColor = System.Drawing.Color.White;
            this.dgvPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrecios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrecios.Location = new System.Drawing.Point(3, 3);
            this.dgvPrecios.MultiSelect = false;
            this.dgvPrecios.Name = "dgvPrecios";
            this.dgvPrecios.ReadOnly = true;
            this.dgvPrecios.RowHeadersVisible = false;
            this.dgvPrecios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrecios.Size = new System.Drawing.Size(269, 307);
            this.dgvPrecios.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvStock);
            this.tabPage2.Controls.Add(this.pnlTotalStock);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(275, 313);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Stock";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.BackgroundColor = System.Drawing.Color.White;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStock.Location = new System.Drawing.Point(3, 3);
            this.dgvStock.MultiSelect = false;
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersVisible = false;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(269, 268);
            this.dgvStock.TabIndex = 6;
            // 
            // pnlTotalStock
            // 
            this.pnlTotalStock.BackColor = System.Drawing.Color.LightGray;
            this.pnlTotalStock.Controls.Add(this.nudStockActual);
            this.pnlTotalStock.Controls.Add(this.label1);
            this.pnlTotalStock.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotalStock.Location = new System.Drawing.Point(3, 271);
            this.pnlTotalStock.Name = "pnlTotalStock";
            this.pnlTotalStock.Size = new System.Drawing.Size(269, 39);
            this.pnlTotalStock.TabIndex = 0;
            // 
            // nudStockActual
            // 
            this.nudStockActual.DecimalPlaces = 2;
            this.nudStockActual.Enabled = false;
            this.nudStockActual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStockActual.Location = new System.Drawing.Point(142, 6);
            this.nudStockActual.Maximum = new decimal(new int[] {
            -1486618624,
            232830643,
            0,
            0});
            this.nudStockActual.Name = "nudStockActual";
            this.nudStockActual.Size = new System.Drawing.Size(149, 26);
            this.nudStockActual.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "STOCK ACTUAL";
            // 
            // pnlFoto
            // 
            this.pnlFoto.BackColor = System.Drawing.Color.Silver;
            this.pnlFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFoto.Controls.Add(this.lblFoto);
            this.pnlFoto.Controls.Add(this.imgFoto);
            this.pnlFoto.Location = new System.Drawing.Point(77, 159);
            this.pnlFoto.Margin = new System.Windows.Forms.Padding(2);
            this.pnlFoto.Name = "pnlFoto";
            this.pnlFoto.Size = new System.Drawing.Size(217, 200);
            this.pnlFoto.TabIndex = 207;
            // 
            // lblFoto
            // 
            this.lblFoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblFoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoto.Location = new System.Drawing.Point(0, 0);
            this.lblFoto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(215, 32);
            this.lblFoto.TabIndex = 84;
            this.lblFoto.Text = "Foto";
            this.lblFoto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imgFoto
            // 
            this.imgFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgFoto.BackColor = System.Drawing.Color.White;
            this.imgFoto.Location = new System.Drawing.Point(14, 34);
            this.imgFoto.Margin = new System.Windows.Forms.Padding(2);
            this.imgFoto.Name = "imgFoto";
            this.imgFoto.Size = new System.Drawing.Size(189, 152);
            this.imgFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFoto.TabIndex = 0;
            this.imgFoto.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(20, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 32);
            this.label6.TabIndex = 212;
            this.label6.Text = "Unidad\r\nMedida";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label21.Location = new System.Drawing.Point(29, 41);
            this.label21.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 16);
            this.label21.TabIndex = 211;
            this.label21.Text = "Rubro";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarca.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblMarca.Location = new System.Drawing.Point(28, 10);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(46, 16);
            this.lblMarca.TabIndex = 210;
            this.lblMarca.Text = "Marca";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(77, 7);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(218, 22);
            this.txtMarca.TabIndex = 213;
            // 
            // txtRubro
            // 
            this.txtRubro.Enabled = false;
            this.txtRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRubro.Location = new System.Drawing.Point(78, 38);
            this.txtRubro.Margin = new System.Windows.Forms.Padding(2);
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.Size = new System.Drawing.Size(217, 22);
            this.txtRubro.TabIndex = 214;
            // 
            // txtUnidad
            // 
            this.txtUnidad.Enabled = false;
            this.txtUnidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnidad.Location = new System.Drawing.Point(78, 71);
            this.txtUnidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnidad.Name = "txtUnidad";
            this.txtUnidad.Size = new System.Drawing.Size(84, 22);
            this.txtUnidad.TabIndex = 215;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIva.Location = new System.Drawing.Point(212, 71);
            this.txtIva.Margin = new System.Windows.Forms.Padding(2);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(83, 22);
            this.txtIva.TabIndex = 217;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(177, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 16);
            this.label2.TabIndex = 216;
            this.label2.Text = "Iva";
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUbicacion.Location = new System.Drawing.Point(78, 107);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtUbicacion.Multiline = true;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(216, 44);
            this.txtUbicacion.TabIndex = 219;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(5, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 218;
            this.label3.Text = "Ubicación";
            // 
            // _00017_Articulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 523);
            this.Name = "_00017_Articulo";
            this.Text = "Articulo";
            this.tabControlDetalle.ResumeLayout(false);
            this.tabPageDetalle.ResumeLayout(false);
            this.tabPageDetalle.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrecios)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.pnlTotalStock.ResumeLayout(false);
            this.pnlTotalStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockActual)).EndInit();
            this.pnlFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel pnlTotalStock;
        private System.Windows.Forms.NumericUpDown nudStockActual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.DataGridView dgvPrecios;
        private System.Windows.Forms.Panel pnlFoto;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.PictureBox imgFoto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUnidad;
        private System.Windows.Forms.TextBox txtRubro;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.Label label3;
    }
}