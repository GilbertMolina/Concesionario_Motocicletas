namespace CapaPresentacion
{
    partial class frmReporte_N
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte_N));
            this.pbMantenimiento = new System.Windows.Forms.PictureBox();
            this.btCerrar = new System.Windows.Forms.Button();
            this.lbNoImplementado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMantenimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMantenimiento
            // 
            this.pbMantenimiento.Image = global::CapaPresentacion.Properties.Resources.mantenimiento;
            this.pbMantenimiento.Location = new System.Drawing.Point(167, 36);
            this.pbMantenimiento.Name = "pbMantenimiento";
            this.pbMantenimiento.Size = new System.Drawing.Size(257, 225);
            this.pbMantenimiento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbMantenimiento.TabIndex = 23;
            this.pbMantenimiento.TabStop = false;
            // 
            // btCerrar
            // 
            this.btCerrar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btCerrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btCerrar.Location = new System.Drawing.Point(260, 309);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(75, 31);
            this.btCerrar.TabIndex = 22;
            this.btCerrar.Text = "Cerrar";
            this.btCerrar.UseVisualStyleBackColor = false;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // lbNoImplementado
            // 
            this.lbNoImplementado.AutoSize = true;
            this.lbNoImplementado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNoImplementado.Location = new System.Drawing.Point(209, 268);
            this.lbNoImplementado.Name = "lbNoImplementado";
            this.lbNoImplementado.Size = new System.Drawing.Size(175, 24);
            this.lbNoImplementado.TabIndex = 21;
            this.lbNoImplementado.Text = "No Implementado";
            // 
            // frmReporte_N
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 402);
            this.Controls.Add(this.pbMantenimiento);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.lbNoImplementado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReporte_N";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Número N";
            ((System.ComponentModel.ISupportInitialize)(this.pbMantenimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMantenimiento;
        internal System.Windows.Forms.Button btCerrar;
        private System.Windows.Forms.Label lbNoImplementado;
    }
}