namespace RecursosHumanos
{
    partial class MenuProcesos
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
            this.btNomina = new System.Windows.Forms.Button();
            this.btVacaciones = new System.Windows.Forms.Button();
            this.btPermisos = new System.Windows.Forms.Button();
            this.btLicencias = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btNomina
            // 
            this.btNomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNomina.Location = new System.Drawing.Point(29, 12);
            this.btNomina.Name = "btNomina";
            this.btNomina.Size = new System.Drawing.Size(135, 31);
            this.btNomina.TabIndex = 2;
            this.btNomina.Text = "Nomina";
            this.btNomina.UseVisualStyleBackColor = true;
            this.btNomina.Click += new System.EventHandler(this.btNomina_Click);
            // 
            // btVacaciones
            // 
            this.btVacaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVacaciones.Location = new System.Drawing.Point(29, 69);
            this.btVacaciones.Name = "btVacaciones";
            this.btVacaciones.Size = new System.Drawing.Size(135, 31);
            this.btVacaciones.TabIndex = 3;
            this.btVacaciones.Text = "Vacaciones";
            this.btVacaciones.UseVisualStyleBackColor = true;
            this.btVacaciones.Click += new System.EventHandler(this.btVacaciones_Click);
            // 
            // btPermisos
            // 
            this.btPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPermisos.Location = new System.Drawing.Point(29, 128);
            this.btPermisos.Name = "btPermisos";
            this.btPermisos.Size = new System.Drawing.Size(135, 31);
            this.btPermisos.TabIndex = 4;
            this.btPermisos.Text = "Permisos";
            this.btPermisos.UseVisualStyleBackColor = true;
            this.btPermisos.Click += new System.EventHandler(this.btPermisos_Click);
            // 
            // btLicencias
            // 
            this.btLicencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLicencias.Location = new System.Drawing.Point(29, 189);
            this.btLicencias.Name = "btLicencias";
            this.btLicencias.Size = new System.Drawing.Size(135, 31);
            this.btLicencias.TabIndex = 5;
            this.btLicencias.Text = "Licencias";
            this.btLicencias.UseVisualStyleBackColor = true;
            this.btLicencias.Click += new System.EventHandler(this.btLicencias_Click);
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(29, 250);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(135, 31);
            this.btVolver.TabIndex = 6;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // MenuProcesos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(194, 296);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btLicencias);
            this.Controls.Add(this.btPermisos);
            this.Controls.Add(this.btVacaciones);
            this.Controls.Add(this.btNomina);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuProcesos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuProcesos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btNomina;
        private System.Windows.Forms.Button btVacaciones;
        private System.Windows.Forms.Button btPermisos;
        private System.Windows.Forms.Button btLicencias;
        private System.Windows.Forms.Button btVolver;
    }
}