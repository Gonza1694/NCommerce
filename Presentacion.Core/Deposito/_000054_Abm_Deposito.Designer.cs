namespace Presentacion.Core.Deposito
{
    partial class _000054_Abm_Deposito
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
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.txt_ubicacion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_ubicacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(181, 138);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(280, 22);
            this.txt_descripcion.TabIndex = 4;
            // 
            // txt_ubicacion
            // 
            this.txt_ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ubicacion.Location = new System.Drawing.Point(181, 187);
            this.txt_ubicacion.Name = "txt_ubicacion";
            this.txt_ubicacion.Size = new System.Drawing.Size(280, 22);
            this.txt_ubicacion.TabIndex = 5;
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(88, 138);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(87, 18);
            this.lbl_descripcion.TabIndex = 6;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // lbl_ubicacion
            // 
            this.lbl_ubicacion.AutoSize = true;
            this.lbl_ubicacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ubicacion.Location = new System.Drawing.Point(101, 188);
            this.lbl_ubicacion.Name = "lbl_ubicacion";
            this.lbl_ubicacion.Size = new System.Drawing.Size(74, 18);
            this.lbl_ubicacion.TabIndex = 7;
            this.lbl_ubicacion.Text = "Ubicacion";
            // 
            // _000054_Abm_Deposito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 298);
            this.Controls.Add(this.lbl_ubicacion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.txt_ubicacion);
            this.Controls.Add(this.txt_descripcion);
            this.Name = "_000054_Abm_Deposito";
            this.Text = "_000054_Abm_Deposito";
            this.Controls.SetChildIndex(this.txt_descripcion, 0);
            this.Controls.SetChildIndex(this.txt_ubicacion, 0);
            this.Controls.SetChildIndex(this.lbl_descripcion, 0);
            this.Controls.SetChildIndex(this.lbl_ubicacion, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.TextBox txt_ubicacion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_ubicacion;
    }
}