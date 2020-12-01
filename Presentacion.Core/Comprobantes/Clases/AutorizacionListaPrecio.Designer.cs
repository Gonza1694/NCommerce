namespace Presentacion.Core.Comprobantes.Clases
{
    partial class AutorizacionListaPrecio
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
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.PB_ojo_cerrado = new System.Windows.Forms.PictureBox();
            this.PB_ojo_abierto = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_cerrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_abierto)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Tomato;
            this.btn_cancelar.FlatAppearance.BorderSize = 2;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.OrangeRed;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.Tomato;
            this.btn_cancelar.Location = new System.Drawing.Point(210, 137);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(104, 37);
            this.btn_cancelar.TabIndex = 25;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_ingresar
            // 
            this.btn_ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ingresar.FlatAppearance.BorderColor = System.Drawing.Color.LightGreen;
            this.btn_ingresar.FlatAppearance.BorderSize = 2;
            this.btn_ingresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.btn_ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ingresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ingresar.ForeColor = System.Drawing.Color.LightGreen;
            this.btn_ingresar.Location = new System.Drawing.Point(18, 137);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(106, 37);
            this.btn_ingresar.TabIndex = 24;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            // 
            // txt_pass
            // 
            this.txt_pass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.txt_pass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_pass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.ForeColor = System.Drawing.Color.Black;
            this.txt_pass.Location = new System.Drawing.Point(44, 68);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(199, 15);
            this.txt_pass.TabIndex = 23;
            this.txt_pass.Text = "Contraseña";
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.Black;
            this.txt_user.Location = new System.Drawing.Point(44, 25);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(199, 15);
            this.txt_user.TabIndex = 22;
            this.txt_user.Text = "Usuario";
            // 
            // PB_ojo_cerrado
            // 
            this.PB_ojo_cerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_ojo_cerrado.Image = global::Presentacion.Core.Properties.Resources.openEye;
            this.PB_ojo_cerrado.Location = new System.Drawing.Point(249, 68);
            this.PB_ojo_cerrado.Name = "PB_ojo_cerrado";
            this.PB_ojo_cerrado.Size = new System.Drawing.Size(23, 21);
            this.PB_ojo_cerrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ojo_cerrado.TabIndex = 26;
            this.PB_ojo_cerrado.TabStop = false;
            // 
            // PB_ojo_abierto
            // 
            this.PB_ojo_abierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_ojo_abierto.Image = global::Presentacion.Core.Properties.Resources.closeEye;
            this.PB_ojo_abierto.Location = new System.Drawing.Point(278, 68);
            this.PB_ojo_abierto.Name = "PB_ojo_abierto";
            this.PB_ojo_abierto.Size = new System.Drawing.Size(23, 21);
            this.PB_ojo_abierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ojo_abierto.TabIndex = 27;
            this.PB_ojo_abierto.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(337, 205);
            this.shapeContainer1.TabIndex = 28;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 39;
            this.lineShape1.X2 = 217;
            this.lineShape1.Y1 = 46;
            this.lineShape1.Y2 = 46;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 40;
            this.lineShape2.X2 = 218;
            this.lineShape2.Y1 = 87;
            this.lineShape2.Y2 = 87;
            // 
            // AutorizacionListaPrecio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(337, 205);
            this.Controls.Add(this.PB_ojo_cerrado);
            this.Controls.Add(this.PB_ojo_abierto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "AutorizacionListaPrecio";
            this.Text = "AutorizacionListaPrecio";
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_cerrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_abierto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PB_ojo_cerrado;
        private System.Windows.Forms.PictureBox PB_ojo_abierto;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ingresar;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}