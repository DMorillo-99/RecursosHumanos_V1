namespace RecursosHumanos
{
    partial class Menu1
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
            this.btMantenimientos = new System.Windows.Forms.Button();
            this.btProcesos = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btReportes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMantenimientos
            // 
            this.btMantenimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMantenimientos.Location = new System.Drawing.Point(13, 13);
            this.btMantenimientos.Name = "btMantenimientos";
            this.btMantenimientos.Size = new System.Drawing.Size(135, 31);
            this.btMantenimientos.TabIndex = 0;
            this.btMantenimientos.Text = "Mantenimientos";
            this.btMantenimientos.UseVisualStyleBackColor = true;
            this.btMantenimientos.Click += new System.EventHandler(this.btMantenimientos_Click);
            // 
            // btProcesos
            // 
            this.btProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btProcesos.Location = new System.Drawing.Point(13, 73);
            this.btProcesos.Name = "btProcesos";
            this.btProcesos.Size = new System.Drawing.Size(135, 31);
            this.btProcesos.TabIndex = 1;
            this.btProcesos.Text = "Procesos";
            this.btProcesos.UseVisualStyleBackColor = true;
            this.btProcesos.Click += new System.EventHandler(this.btProcesos_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(13, 193);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(135, 31);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "Salir";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btReportes
            // 
            this.btReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReportes.Location = new System.Drawing.Point(13, 135);
            this.btReportes.Name = "btReportes";
            this.btReportes.Size = new System.Drawing.Size(135, 31);
            this.btReportes.TabIndex = 3;
            this.btReportes.Text = "Reportes";
            this.btReportes.UseVisualStyleBackColor = true;
            this.btReportes.Click += new System.EventHandler(this.btReportes_Click);
            // 
            // Menu1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 236);
            this.Controls.Add(this.btReportes);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btProcesos);
            this.Controls.Add(this.btMantenimientos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMantenimientos;
        private System.Windows.Forms.Button btProcesos;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btReportes;
    }
}

