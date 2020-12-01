namespace CommerceApp
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_user = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pic_logoLateral = new System.Windows.Forms.PictureBox();
            this.lbl_titulo_venta = new System.Windows.Forms.Label();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.PB_ojo_cerrado = new System.Windows.Forms.PictureBox();
            this.PB_ojo_abierto = new System.Windows.Forms.PictureBox();
            this.btn_ingresar = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoLateral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_cerrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_abierto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_user
            // 
            this.txt_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(48)))));
            this.txt_user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_user.Location = new System.Drawing.Point(262, 102);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(199, 15);
            this.txt_user.TabIndex = 1;
            this.txt_user.Text = "opais";
            this.txt_user.Enter += new System.EventHandler(this.txt_user_Enter);
            this.txt_user.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_user_KeyPress);
            this.txt_user.Leave += new System.EventHandler(this.txt_user_Leave);
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label9);
            this.panelLogin.Controls.Add(this.pic_logoLateral);
            this.panelLogin.Location = new System.Drawing.Point(0, 3);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(235, 277);
            this.panelLogin.TabIndex = 0;
            this.panelLogin.TabStop = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Location = new System.Drawing.Point(195, 256);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 17;
            this.label9.Text = "v 1.0";
            // 
            // pic_logoLateral
            // 
            this.pic_logoLateral.Image = global::CommerceApp.Properties.Resources.LogoB;
            this.pic_logoLateral.Location = new System.Drawing.Point(12, 46);
            this.pic_logoLateral.Name = "pic_logoLateral";
            this.pic_logoLateral.Size = new System.Drawing.Size(213, 158);
            this.pic_logoLateral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_logoLateral.TabIndex = 15;
            this.pic_logoLateral.TabStop = false;
            // 
            // lbl_titulo_venta
            // 
            this.lbl_titulo_venta.AutoSize = true;
            this.lbl_titulo_venta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lbl_titulo_venta.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_titulo_venta.Location = new System.Drawing.Point(257, 9);
            this.lbl_titulo_venta.Name = "lbl_titulo_venta";
            this.lbl_titulo_venta.Size = new System.Drawing.Size(158, 29);
            this.lbl_titulo_venta.TabIndex = 1;
            this.lbl_titulo_venta.Text = "Iniciar Sesión";
            this.lbl_titulo_venta.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txt_password
            // 
            this.txt_password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(48)))));
            this.txt_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txt_password.Location = new System.Drawing.Point(262, 145);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(199, 15);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "P$assword123";
            this.txt_password.Enter += new System.EventHandler(this.txt_password_Enter);
            this.txt_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_password_KeyPress);
            this.txt_password.Leave += new System.EventHandler(this.txt_password_Leave);
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
            this.btn_cancelar.Location = new System.Drawing.Point(467, 214);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(104, 37);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cerrar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2,
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(619, 283);
            this.shapeContainer1.TabIndex = 19;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape2.BorderWidth = 3;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 262;
            this.lineShape2.X2 = 460;
            this.lineShape2.Y1 = 163;
            this.lineShape2.Y2 = 163;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.LightGreen;
            this.lineShape1.BorderWidth = 3;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 262;
            this.lineShape1.X2 = 460;
            this.lineShape1.Y1 = 120;
            this.lineShape1.Y2 = 120;
            // 
            // PB_ojo_cerrado
            // 
            this.PB_ojo_cerrado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_ojo_cerrado.Image = global::CommerceApp.Properties.Resources.ClosedEye;
            this.PB_ojo_cerrado.Location = new System.Drawing.Point(467, 143);
            this.PB_ojo_cerrado.Name = "PB_ojo_cerrado";
            this.PB_ojo_cerrado.Size = new System.Drawing.Size(23, 21);
            this.PB_ojo_cerrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ojo_cerrado.TabIndex = 20;
            this.PB_ojo_cerrado.TabStop = false;
            this.PB_ojo_cerrado.Click += new System.EventHandler(this.PB_ojo_cerrado_Click);
            // 
            // PB_ojo_abierto
            // 
            this.PB_ojo_abierto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_ojo_abierto.Image = global::CommerceApp.Properties.Resources.OpenedEye;
            this.PB_ojo_abierto.Location = new System.Drawing.Point(467, 143);
            this.PB_ojo_abierto.Name = "PB_ojo_abierto";
            this.PB_ojo_abierto.Size = new System.Drawing.Size(23, 21);
            this.PB_ojo_abierto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ojo_abierto.TabIndex = 21;
            this.PB_ojo_abierto.TabStop = false;
            this.PB_ojo_abierto.Click += new System.EventHandler(this.PB_ojo_abierto_Click);
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
            this.btn_ingresar.Location = new System.Drawing.Point(265, 214);
            this.btn_ingresar.Name = "btn_ingresar";
            this.btn_ingresar.Size = new System.Drawing.Size(106, 37);
            this.btn_ingresar.TabIndex = 3;
            this.btn_ingresar.Text = "Ingresar";
            this.btn_ingresar.UseVisualStyleBackColor = true;
            this.btn_ingresar.Click += new System.EventHandler(this.btn_ingresar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(91)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(619, 283);
            this.Controls.Add(this.PB_ojo_cerrado);
            this.Controls.Add(this.PB_ojo_abierto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_ingresar);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_titulo_venta);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.Opacity = 0.85D;
            this.Text = "FormLogin";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_logoLateral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_cerrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ojo_abierto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label lbl_titulo_venta;
        private System.Windows.Forms.PictureBox pic_logoLateral;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label label9;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private System.Windows.Forms.PictureBox PB_ojo_cerrado;
        private System.Windows.Forms.PictureBox PB_ojo_abierto;
        private System.Windows.Forms.Button btn_ingresar;
    }
}