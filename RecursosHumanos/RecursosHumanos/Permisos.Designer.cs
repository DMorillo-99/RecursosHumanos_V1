namespace RecursosHumanos
{
    partial class Permisos
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
            this.permisoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.permisoTableAdapter = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.PermisoTableAdapter();
            this.tableAdapterManager = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager();
            this.permisoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btVolver = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtInicioFecha = new System.Windows.Forms.TextBox();
            this.txtFinFecha = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtComentario = new System.Windows.Forms.TextBox();
            codigo_EmpleadoLabel = new System.Windows.Forms.Label();
            inicio_FechaLabel = new System.Windows.Forms.Label();
            fin_FechaLabel = new System.Windows.Forms.Label();
            añoLabel = new System.Windows.Forms.Label();
            comentarioLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recursosHumanosDataSet
            // 
            this.recursosHumanosDataSet.DataSetName = "RecursosHumanosDataSet";
            this.recursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // permisoBindingSource
            // 
            this.permisoBindingSource.DataMember = "Permiso";
            this.permisoBindingSource.DataSource = this.recursosHumanosDataSet;
            // 
            // permisoTableAdapter
            // 
            this.permisoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.LicenciaTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.PermisoTableAdapter = this.permisoTableAdapter;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacacionesTableAdapter = null;
            // 
            // permisoDataGridView
            // 
            this.permisoDataGridView.AutoGenerateColumns = false;
            this.permisoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.permisoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.permisoDataGridView.DataSource = this.permisoBindingSource;
            this.permisoDataGridView.Location = new System.Drawing.Point(385, 12);
            this.permisoDataGridView.Name = "permisoDataGridView";
            this.permisoDataGridView.Size = new System.Drawing.Size(543, 220);
            this.permisoDataGridView.TabIndex = 1;
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
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(227, 136);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(135, 31);
            this.btVolver.TabIndex = 25;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(14, 136);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(135, 31);
            this.btRegistrar.TabIndex = 24;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // codigo_EmpleadoLabel
            // 
            codigo_EmpleadoLabel.AutoSize = true;
            codigo_EmpleadoLabel.Location = new System.Drawing.Point(11, 15);
            codigo_EmpleadoLabel.Name = "codigo_EmpleadoLabel";
            codigo_EmpleadoLabel.Size = new System.Drawing.Size(93, 13);
            codigo_EmpleadoLabel.TabIndex = 14;
            codigo_EmpleadoLabel.Text = "Codigo Empleado:";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(110, 12);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoEmpleado.TabIndex = 15;
            // 
            // inicio_FechaLabel
            // 
            inicio_FechaLabel.AutoSize = true;
            inicio_FechaLabel.Location = new System.Drawing.Point(11, 41);
            inicio_FechaLabel.Name = "inicio_FechaLabel";
            inicio_FechaLabel.Size = new System.Drawing.Size(68, 13);
            inicio_FechaLabel.TabIndex = 16;
            inicio_FechaLabel.Text = "Inicio Fecha:";
            // 
            // txtInicioFecha
            // 
            this.txtInicioFecha.Location = new System.Drawing.Point(110, 38);
            this.txtInicioFecha.Name = "txtInicioFecha";
            this.txtInicioFecha.Size = new System.Drawing.Size(100, 20);
            this.txtInicioFecha.TabIndex = 17;
            // 
            // fin_FechaLabel
            // 
            fin_FechaLabel.AutoSize = true;
            fin_FechaLabel.Location = new System.Drawing.Point(11, 67);
            fin_FechaLabel.Name = "fin_FechaLabel";
            fin_FechaLabel.Size = new System.Drawing.Size(57, 13);
            fin_FechaLabel.TabIndex = 18;
            fin_FechaLabel.Text = "Fin Fecha:";
            // 
            // txtFinFecha
            // 
            this.txtFinFecha.Location = new System.Drawing.Point(110, 64);
            this.txtFinFecha.Name = "txtFinFecha";
            this.txtFinFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFinFecha.TabIndex = 19;
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(11, 93);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(29, 13);
            añoLabel.TabIndex = 20;
            añoLabel.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.Location = new System.Drawing.Point(110, 90);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 21;
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Location = new System.Drawing.Point(224, 12);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(63, 13);
            comentarioLabel.TabIndex = 22;
            comentarioLabel.Text = "Comentario:";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(227, 28);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(152, 82);
            this.txtComentario.TabIndex = 23;
            // 
            // Permisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 253);
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
            this.Controls.Add(this.permisoDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Permisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permisos";
            this.Load += new System.EventHandler(this.Permisos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.permisoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RecursosHumanosDataSet recursosHumanosDataSet;
        private System.Windows.Forms.BindingSource permisoBindingSource;
        private RecursosHumanosDataSetTableAdapters.PermisoTableAdapter permisoTableAdapter;
        private RecursosHumanosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView permisoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtInicioFecha;
        private System.Windows.Forms.TextBox txtFinFecha;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtComentario;
    }
}