namespace RecursosHumanos
{
    partial class Menu_Mantenimeinto
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
            this.btEmpleados = new System.Windows.Forms.Button();
            this.btDepartamentos = new System.Windows.Forms.Button();
            this.btCargo = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btEmpleados
            // 
            this.btEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEmpleados.Location = new System.Drawing.Point(34, 12);
            this.btEmpleados.Name = "btEmpleados";
            this.btEmpleados.Size = new System.Drawing.Size(108, 33);
            this.btEmpleados.TabIndex = 0;
            this.btEmpleados.Text = "Empleados";
            this.btEmpleados.UseVisualStyleBackColor = true;
            this.btEmpleados.Click += new System.EventHandler(this.btEmpleados_Click);
            // 
            // btDepartamentos
            // 
            this.btDepartamentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDepartamentos.Location = new System.Drawing.Point(24, 63);
            this.btDepartamentos.Name = "btDepartamentos";
            this.btDepartamentos.Size = new System.Drawing.Size(131, 33);
            this.btDepartamentos.TabIndex = 1;
            this.btDepartamentos.Text = "Departamentos";
            this.btDepartamentos.UseVisualStyleBackColor = true;
            this.btDepartamentos.Click += new System.EventHandler(this.btDepartamentos_Click);
            // 
            // btCargo
            // 
            this.btCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCargo.Location = new System.Drawing.Point(24, 122);
            this.btCargo.Name = "btCargo";
            this.btCargo.Size = new System.Drawing.Size(131, 33);
            this.btCargo.TabIndex = 2;
            this.btCargo.Text = "Cargo";
            this.btCargo.UseVisualStyleBackColor = true;
            this.btCargo.Click += new System.EventHandler(this.btCargo_Click);
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(24, 178);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(131, 33);
            this.btVolver.TabIndex = 3;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // Menu_Mantenimeinto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 227);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btCargo);
            this.Controls.Add(this.btDepartamentos);
            this.Controls.Add(this.btEmpleados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Mantenimeinto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu_Mantenimeinto";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btEmpleados;
        private System.Windows.Forms.Button btDepartamentos;
        private System.Windows.Forms.Button btCargo;
        private System.Windows.Forms.Button btVolver;
    }
}