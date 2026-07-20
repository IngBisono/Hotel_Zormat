namespace Hotel_Zormat
{
    partial class FrmNuevaReserva
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
            this.lblTipoReserva = new System.Windows.Forms.Label();
            this.lblNoches = new System.Windows.Forms.Label();
            this.cboTipoHabitacion = new System.Windows.Forms.ComboBox();
            this.txtNochesHab = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTipoReserva
            // 
            this.lblTipoReserva.AutoSize = true;
            this.lblTipoReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoReserva.Location = new System.Drawing.Point(111, 75);
            this.lblTipoReserva.Name = "lblTipoReserva";
            this.lblTipoReserva.Size = new System.Drawing.Size(48, 20);
            this.lblTipoReserva.TabIndex = 0;
            this.lblTipoReserva.Text = "Tipo:";
            // 
            // lblNoches
            // 
            this.lblNoches.AutoSize = true;
            this.lblNoches.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoches.Location = new System.Drawing.Point(111, 182);
            this.lblNoches.Name = "lblNoches";
            this.lblNoches.Size = new System.Drawing.Size(74, 20);
            this.lblNoches.TabIndex = 1;
            this.lblNoches.Text = "Noches:";
            // 
            // cboTipoHabitacion
            // 
            this.cboTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoHabitacion.FormattingEnabled = true;
            this.cboTipoHabitacion.Location = new System.Drawing.Point(260, 77);
            this.cboTipoHabitacion.Name = "cboTipoHabitacion";
            this.cboTipoHabitacion.Size = new System.Drawing.Size(121, 28);
            this.cboTipoHabitacion.TabIndex = 2;
            // 
            // txtNochesHab
            // 
            this.txtNochesHab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNochesHab.Location = new System.Drawing.Point(260, 184);
            this.txtNochesHab.Name = "txtNochesHab";
            this.txtNochesHab.Size = new System.Drawing.Size(121, 26);
            this.txtNochesHab.TabIndex = 3;
            // 
            // FrmNuevaReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 327);
            this.Controls.Add(this.txtNochesHab);
            this.Controls.Add(this.cboTipoHabitacion);
            this.Controls.Add(this.lblNoches);
            this.Controls.Add(this.lblTipoReserva);
            this.Name = "FrmNuevaReserva";
            this.Text = "FrmNuevaReserva";
            this.Load += new System.EventHandler(this.FrmNuevaReserva_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTipoReserva;
        private System.Windows.Forms.Label lblNoches;
        private System.Windows.Forms.ComboBox cboTipoHabitacion;
        private System.Windows.Forms.TextBox txtNochesHab;
    }
}