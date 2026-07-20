namespace Hotel_Zormat
{
    partial class FrmHabitacion
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
            this.lblNumeroHab = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtNumeroHab = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.lblEstadoHab = new System.Windows.Forms.Label();
            this.btnCambiarColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumeroHab
            // 
            this.lblNumeroHab.AutoSize = true;
            this.lblNumeroHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroHab.Location = new System.Drawing.Point(69, 53);
            this.lblNumeroHab.Name = "lblNumeroHab";
            this.lblNumeroHab.Size = new System.Drawing.Size(76, 20);
            this.lblNumeroHab.TabIndex = 0;
            this.lblNumeroHab.Text = "Numero:";
            this.lblNumeroHab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.Location = new System.Drawing.Point(69, 107);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(48, 20);
            this.lblTipo.TabIndex = 1;
            this.lblTipo.Text = "Tipo:";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(69, 162);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(71, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "Estado:";
            this.lblEstado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumeroHab
            // 
            this.txtNumeroHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroHab.Location = new System.Drawing.Point(202, 47);
            this.txtNumeroHab.Name = "txtNumeroHab";
            this.txtNumeroHab.Size = new System.Drawing.Size(161, 26);
            this.txtNumeroHab.TabIndex = 3;
            // 
            // txtEstado
            // 
            this.txtEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEstado.Location = new System.Drawing.Point(202, 156);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(161, 26);
            this.txtEstado.TabIndex = 4;
            // 
            // txtTipo
            // 
            this.txtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipo.Location = new System.Drawing.Point(202, 101);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(161, 26);
            this.txtTipo.TabIndex = 5;
            // 
            // lblEstadoHab
            // 
            this.lblEstadoHab.AutoSize = true;
            this.lblEstadoHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoHab.Location = new System.Drawing.Point(211, 164);
            this.lblEstadoHab.Name = "lblEstadoHab";
            this.lblEstadoHab.Size = new System.Drawing.Size(52, 13);
            this.lblEstadoHab.TabIndex = 6;
            this.lblEstadoHab.Text = "Muestra";
            this.lblEstadoHab.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCambiarColor
            // 
            this.btnCambiarColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiarColor.Location = new System.Drawing.Point(202, 205);
            this.btnCambiarColor.Name = "btnCambiarColor";
            this.btnCambiarColor.Size = new System.Drawing.Size(161, 31);
            this.btnCambiarColor.TabIndex = 7;
            this.btnCambiarColor.Text = "Cambiar Color";
            this.btnCambiarColor.UseVisualStyleBackColor = true;
            this.btnCambiarColor.Click += new System.EventHandler(this.btnCambiarColor_Click);
            // 
            // FrmHabitacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 258);
            this.Controls.Add(this.btnCambiarColor);
            this.Controls.Add(this.lblEstadoHab);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtNumeroHab);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumeroHab);
            this.Name = "FrmHabitacion";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumeroHab;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtNumeroHab;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.Label lblEstadoHab;
        private System.Windows.Forms.Button btnCambiarColor;
    }
}