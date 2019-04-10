namespace RecursosHumanos
{
    partial class Departamentos
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
            System.Windows.Forms.Label codigo_DepartamentoLabel;
            System.Windows.Forms.Label nombre_DepartamentoLabel;
            System.Windows.Forms.Label encargadoLabel;
            this.recursosHumanosDataSet = new RecursosHumanos.RecursosHumanosDataSet();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosTableAdapter = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.DepartamentosTableAdapter();
            this.tableAdapterManager = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager();
            this.departamentosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtEncargado = new System.Windows.Forms.TextBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            codigo_DepartamentoLabel = new System.Windows.Forms.Label();
            nombre_DepartamentoLabel = new System.Windows.Forms.Label();
            encargadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recursosHumanosDataSet
            // 
            this.recursosHumanosDataSet.DataSetName = "RecursosHumanosDataSet";
            this.recursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "Departamentos";
            this.departamentosBindingSource.DataSource = this.recursosHumanosDataSet;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = this.departamentosTableAdapter;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.LicenciaTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.PermisoTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacacionesTableAdapter = null;
            // 
            // departamentosDataGridView
            // 
            this.departamentosDataGridView.AutoGenerateColumns = false;
            this.departamentosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.departamentosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.departamentosDataGridView.DataSource = this.departamentosBindingSource;
            this.departamentosDataGridView.Location = new System.Drawing.Point(249, 12);
            this.departamentosDataGridView.Name = "departamentosDataGridView";
            this.departamentosDataGridView.Size = new System.Drawing.Size(444, 223);
            this.departamentosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Departamento";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Departamento";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo_Departamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo_Departamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_Departamento";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_Departamento";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Encargado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Encargado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // codigo_DepartamentoLabel
            // 
            codigo_DepartamentoLabel.AutoSize = true;
            codigo_DepartamentoLabel.Location = new System.Drawing.Point(20, 15);
            codigo_DepartamentoLabel.Name = "codigo_DepartamentoLabel";
            codigo_DepartamentoLabel.Size = new System.Drawing.Size(113, 13);
            codigo_DepartamentoLabel.TabIndex = 3;
            codigo_DepartamentoLabel.Text = "Codigo Departamento:";
            // 
            // txtCodigoDepartamento
            // 
            this.txtCodigoDepartamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentosBindingSource, "Codigo_Departamento", true));
            this.txtCodigoDepartamento.Location = new System.Drawing.Point(143, 12);
            this.txtCodigoDepartamento.Name = "txtCodigoDepartamento";
            this.txtCodigoDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoDepartamento.TabIndex = 4;
            // 
            // nombre_DepartamentoLabel
            // 
            nombre_DepartamentoLabel.AutoSize = true;
            nombre_DepartamentoLabel.Location = new System.Drawing.Point(20, 41);
            nombre_DepartamentoLabel.Name = "nombre_DepartamentoLabel";
            nombre_DepartamentoLabel.Size = new System.Drawing.Size(117, 13);
            nombre_DepartamentoLabel.TabIndex = 5;
            nombre_DepartamentoLabel.Text = "Nombre Departamento:";
            // 
            // txtnombre
            // 
            this.txtnombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentosBindingSource, "Nombre_Departamento", true));
            this.txtnombre.Location = new System.Drawing.Point(143, 38);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 6;
            // 
            // encargadoLabel
            // 
            encargadoLabel.AutoSize = true;
            encargadoLabel.Location = new System.Drawing.Point(20, 67);
            encargadoLabel.Name = "encargadoLabel";
            encargadoLabel.Size = new System.Drawing.Size(62, 13);
            encargadoLabel.TabIndex = 7;
            encargadoLabel.Text = "Encargado:";
            // 
            // txtEncargado
            // 
            this.txtEncargado.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.departamentosBindingSource, "Encargado", true));
            this.txtEncargado.Location = new System.Drawing.Point(143, 64);
            this.txtEncargado.Name = "txtEncargado";
            this.txtEncargado.Size = new System.Drawing.Size(100, 20);
            this.txtEncargado.TabIndex = 8;
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(126, 204);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(99, 31);
            this.btVolver.TabIndex = 32;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // btBuscar
            // 
            this.btBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBuscar.Location = new System.Drawing.Point(126, 150);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(99, 31);
            this.btBuscar.TabIndex = 31;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(12, 204);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 31);
            this.btCancelar.TabIndex = 30;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(12, 150);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(99, 31);
            this.btEliminar.TabIndex = 29;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(127, 94);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(99, 31);
            this.btEditar.TabIndex = 28;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(12, 94);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(99, 31);
            this.btRegistrar.TabIndex = 27;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // Departamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 251);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(codigo_DepartamentoLabel);
            this.Controls.Add(this.txtCodigoDepartamento);
            this.Controls.Add(nombre_DepartamentoLabel);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(encargadoLabel);
            this.Controls.Add(this.txtEncargado);
            this.Controls.Add(this.departamentosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Departamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departamentos";
            this.Load += new System.EventHandler(this.Departamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RecursosHumanosDataSet recursosHumanosDataSet;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private RecursosHumanosDataSetTableAdapters.DepartamentosTableAdapter departamentosTableAdapter;
        private RecursosHumanosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView departamentosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtCodigoDepartamento;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtEncargado;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btRegistrar;
    }
}