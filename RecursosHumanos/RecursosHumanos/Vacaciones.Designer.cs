namespace RecursosHumanos
{
    partial class Vacaciones
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label codigo_EmpleadoLabel;
            System.Windows.Forms.Label inicio_FechaLabel;
            System.Windows.Forms.Label fin_FechaLabel;
            System.Windows.Forms.Label añoLabel;
            System.Windows.Forms.Label comentarioLabel;
            this.recursosHumanosDataSet = new RecursosHumanos.RecursosHumanosDataSet();
            this.vacacionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vacacionesTableAdapter = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.VacacionesTableAdapter();
            this.tableAdapterManager = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager();
            this.vacacionesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtInicioFecha = new System.Windows.Forms.TextBox();
            this.txtFinFecha = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            codigo_EmpleadoLabel = new System.Windows.Forms.Label();
            inicio_FechaLabel = new System.Windows.Forms.Label();
            fin_FechaLabel = new System.Windows.Forms.Label();
            añoLabel = new System.Windows.Forms.Label();
            comentarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacacionesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacacionesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recursosHumanosDataSet
            // 
            this.recursosHumanosDataSet.DataSetName = "RecursosHumanosDataSet";
            this.recursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vacacionesBindingSource
            // 
            this.vacacionesBindingSource.DataMember = "Vacaciones";
            this.vacacionesBindingSource.DataSource = this.recursosHumanosDataSet;
            // 
            // vacacionesTableAdapter
            // 
            this.vacacionesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.LicenciaTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.PermisoTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacacionesTableAdapter = this.vacacionesTableAdapter;
            // 
            // vacacionesDataGridView
            // 
            this.vacacionesDataGridView.AutoGenerateColumns = false;
            this.vacacionesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vacacionesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.vacacionesDataGridView.DataSource = this.vacacionesBindingSource;
            this.vacacionesDataGridView.Location = new System.Drawing.Point(386, 12);
            this.vacacionesDataGridView.Name = "vacacionesDataGridView";
            this.vacacionesDataGridView.Size = new System.Drawing.Size(543, 221);
            this.vacacionesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Codigo_Empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Codigo_Empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Inicio_Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Inicio_Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fin_Fecha";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fin_Fecha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Año";
            this.dataGridViewTextBoxColumn4.HeaderText = "Año";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Comentario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Comentario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // codigo_EmpleadoLabel
            // 
            codigo_EmpleadoLabel.AutoSize = true;
            codigo_EmpleadoLabel.Location = new System.Drawing.Point(12, 12);
            codigo_EmpleadoLabel.Name = "codigo_EmpleadoLabel";
            codigo_EmpleadoLabel.Size = new System.Drawing.Size(93, 13);
            codigo_EmpleadoLabel.TabIndex = 1;
            codigo_EmpleadoLabel.Text = "Codigo Empleado:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacacionesBindingSource, "Codigo_Empleado", true));
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(111, 9);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEmpleado.TabIndex = 2;
            // 
            // inicio_FechaLabel
            // 
            inicio_FechaLabel.AutoSize = true;
            inicio_FechaLabel.Location = new System.Drawing.Point(12, 38);
            inicio_FechaLabel.Name = "inicio_FechaLabel";
            inicio_FechaLabel.Size = new System.Drawing.Size(68, 13);
            inicio_FechaLabel.TabIndex = 3;
            inicio_FechaLabel.Text = "Inicio Fecha:";
            // 
            // txtInicioFecha
            // 
            this.txtInicioFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacacionesBindingSource, "Inicio_Fecha", true));
            this.txtInicioFecha.Location = new System.Drawing.Point(111, 35);
            this.txtInicioFecha.Name = "txtInicioFecha";
            this.txtInicioFecha.Size = new System.Drawing.Size(100, 20);
            this.txtInicioFecha.TabIndex = 4;
            // 
            // fin_FechaLabel
            // 
            fin_FechaLabel.AutoSize = true;
            fin_FechaLabel.Location = new System.Drawing.Point(12, 64);
            fin_FechaLabel.Name = "fin_FechaLabel";
            fin_FechaLabel.Size = new System.Drawing.Size(57, 13);
            fin_FechaLabel.TabIndex = 5;
            fin_FechaLabel.Text = "Fin Fecha:";
            // 
            // txtFinFecha
            // 
            this.txtFinFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacacionesBindingSource, "Fin_Fecha", true));
            this.txtFinFecha.Location = new System.Drawing.Point(111, 61);
            this.txtFinFecha.Name = "txtFinFecha";
            this.txtFinFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFinFecha.TabIndex = 6;
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(12, 90);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(29, 13);
            añoLabel.TabIndex = 7;
            añoLabel.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacacionesBindingSource, "Año", true));
            this.txtAño.Location = new System.Drawing.Point(111, 87);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 8;
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Location = new System.Drawing.Point(225, 9);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(63, 13);
            comentarioLabel.TabIndex = 9;
            comentarioLabel.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vacacionesBindingSource, "Comentario", true));
            this.txtComentario.Location = new System.Drawing.Point(228, 25);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(152, 82);
            this.txtComentario.TabIndex = 10;
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(228, 133);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(135, 31);
            this.btVolver.TabIndex = 13;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(15, 133);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(135, 31);
            this.btRegistrar.TabIndex = 12;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // Vacaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 247);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(codigo_EmpleadoLabel);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(inicio_FechaLabel);
            this.Controls.Add(this.txtInicioFecha);
            this.Controls.Add(fin_FechaLabel);
            this.Controls.Add(this.txtFinFecha);
            this.Controls.Add(añoLabel);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(comentarioLabel);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.vacacionesDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Vacaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vacaciones";
            this.Load += new System.EventHandler(this.Vacaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacacionesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vacacionesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RecursosHumanosDataSet recursosHumanosDataSet;
        private System.Windows.Forms.BindingSource vacacionesBindingSource;
        private RecursosHumanosDataSetTableAdapters.VacacionesTableAdapter vacacionesTableAdapter;
        private RecursosHumanosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView vacacionesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtInicioFecha;
        private System.Windows.Forms.TextBox txtFinFecha;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btRegistrar;
    }
}