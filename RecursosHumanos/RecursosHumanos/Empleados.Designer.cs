namespace RecursosHumanos
{
    partial class Empleados
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
            System.Windows.Forms.Label nombre_EmpleadoLabel;
            System.Windows.Forms.Label apellido_EmpleadoLabel;
            System.Windows.Forms.Label telefono_EmpleadoLabel;
            System.Windows.Forms.Label departamentoLabel;
            System.Windows.Forms.Label cargoLabel;
            System.Windows.Forms.Label fecha_IngresoLabel;
            System.Windows.Forms.Label salarioLabel;
            System.Windows.Forms.Label estatusLabel;
            this.recursosHumanosDataSet = new RecursosHumanos.RecursosHumanosDataSet();
            this.empleadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empleadosTableAdapter = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.EmpleadosTableAdapter();
            this.tableAdapterManager = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager();
            this.empleadosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcodigoEmpleados = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleados = new System.Windows.Forms.TextBox();
            this.txtApellidoEmpleados = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.txtEstatus = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txtEliminar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            codigo_EmpleadoLabel = new System.Windows.Forms.Label();
            nombre_EmpleadoLabel = new System.Windows.Forms.Label();
            apellido_EmpleadoLabel = new System.Windows.Forms.Label();
            telefono_EmpleadoLabel = new System.Windows.Forms.Label();
            departamentoLabel = new System.Windows.Forms.Label();
            cargoLabel = new System.Windows.Forms.Label();
            fecha_IngresoLabel = new System.Windows.Forms.Label();
            salarioLabel = new System.Windows.Forms.Label();
            estatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // recursosHumanosDataSet
            // 
            this.recursosHumanosDataSet.DataSetName = "RecursosHumanosDataSet";
            this.recursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // empleadosBindingSource
            // 
            this.empleadosBindingSource.DataMember = "Empleados";
            this.empleadosBindingSource.DataSource = this.recursosHumanosDataSet;
            // 
            // empleadosTableAdapter
            // 
            this.empleadosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = this.empleadosTableAdapter;
            this.tableAdapterManager.LicenciaTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = null;
            this.tableAdapterManager.PermisoTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacacionesTableAdapter = null;
            // 
            // empleadosDataGridView
            // 
            this.empleadosDataGridView.AutoGenerateColumns = false;
            this.empleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empleadosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.empleadosDataGridView.DataSource = this.empleadosBindingSource;
            this.empleadosDataGridView.Location = new System.Drawing.Point(234, 12);
            this.empleadosDataGridView.Name = "empleadosDataGridView";
            this.empleadosDataGridView.Size = new System.Drawing.Size(1043, 382);
            this.empleadosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Empleado";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Empleado";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo_Empleado";
            this.dataGridViewTextBoxColumn2.HeaderText = "Codigo_Empleado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nombre_Empleado";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre_Empleado";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Apellido_Empleado";
            this.dataGridViewTextBoxColumn4.HeaderText = "Apellido_Empleado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Telefono_Empleado";
            this.dataGridViewTextBoxColumn5.HeaderText = "Telefono_Empleado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Departamento";
            this.dataGridViewTextBoxColumn6.HeaderText = "Departamento";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Cargo";
            this.dataGridViewTextBoxColumn7.HeaderText = "Cargo";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Fecha_Ingreso";
            this.dataGridViewTextBoxColumn8.HeaderText = "Fecha_Ingreso";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Salario";
            this.dataGridViewTextBoxColumn9.HeaderText = "Salario";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Estatus";
            this.dataGridViewTextBoxColumn10.HeaderText = "Estatus";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // codigo_EmpleadoLabel
            // 
            codigo_EmpleadoLabel.AutoSize = true;
            codigo_EmpleadoLabel.Location = new System.Drawing.Point(20, 15);
            codigo_EmpleadoLabel.Name = "codigo_EmpleadoLabel";
            codigo_EmpleadoLabel.Size = new System.Drawing.Size(93, 13);
            codigo_EmpleadoLabel.TabIndex = 3;
            codigo_EmpleadoLabel.Text = "Codigo Empleado:";
            // 
            // txtcodigoEmpleados
            // 
            this.txtcodigoEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Codigo_Empleado", true));
            this.txtcodigoEmpleados.Location = new System.Drawing.Point(128, 12);
            this.txtcodigoEmpleados.Name = "txtcodigoEmpleados";
            this.txtcodigoEmpleados.Size = new System.Drawing.Size(100, 20);
            this.txtcodigoEmpleados.TabIndex = 4;
            // 
            // nombre_EmpleadoLabel
            // 
            nombre_EmpleadoLabel.AutoSize = true;
            nombre_EmpleadoLabel.Location = new System.Drawing.Point(20, 41);
            nombre_EmpleadoLabel.Name = "nombre_EmpleadoLabel";
            nombre_EmpleadoLabel.Size = new System.Drawing.Size(97, 13);
            nombre_EmpleadoLabel.TabIndex = 5;
            nombre_EmpleadoLabel.Text = "Nombre Empleado:";
            // 
            // txtNombreEmpleados
            // 
            this.txtNombreEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Nombre_Empleado", true));
            this.txtNombreEmpleados.Location = new System.Drawing.Point(128, 38);
            this.txtNombreEmpleados.Name = "txtNombreEmpleados";
            this.txtNombreEmpleados.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmpleados.TabIndex = 6;
            // 
            // apellido_EmpleadoLabel
            // 
            apellido_EmpleadoLabel.AutoSize = true;
            apellido_EmpleadoLabel.Location = new System.Drawing.Point(20, 67);
            apellido_EmpleadoLabel.Name = "apellido_EmpleadoLabel";
            apellido_EmpleadoLabel.Size = new System.Drawing.Size(97, 13);
            apellido_EmpleadoLabel.TabIndex = 7;
            apellido_EmpleadoLabel.Text = "Apellido Empleado:";
            // 
            // txtApellidoEmpleados
            // 
            this.txtApellidoEmpleados.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Apellido_Empleado", true));
            this.txtApellidoEmpleados.Location = new System.Drawing.Point(128, 64);
            this.txtApellidoEmpleados.Name = "txtApellidoEmpleados";
            this.txtApellidoEmpleados.Size = new System.Drawing.Size(100, 20);
            this.txtApellidoEmpleados.TabIndex = 8;
            // 
            // telefono_EmpleadoLabel
            // 
            telefono_EmpleadoLabel.AutoSize = true;
            telefono_EmpleadoLabel.Location = new System.Drawing.Point(20, 93);
            telefono_EmpleadoLabel.Name = "telefono_EmpleadoLabel";
            telefono_EmpleadoLabel.Size = new System.Drawing.Size(102, 13);
            telefono_EmpleadoLabel.TabIndex = 9;
            telefono_EmpleadoLabel.Text = "Telefono Empleado:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Telefono_Empleado", true));
            this.txtTelefono.Location = new System.Drawing.Point(128, 90);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // departamentoLabel
            // 
            departamentoLabel.AutoSize = true;
            departamentoLabel.Location = new System.Drawing.Point(20, 119);
            departamentoLabel.Name = "departamentoLabel";
            departamentoLabel.Size = new System.Drawing.Size(77, 13);
            departamentoLabel.TabIndex = 11;
            departamentoLabel.Text = "Departamento:";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Departamento", true));
            this.txtDepartamento.Location = new System.Drawing.Point(128, 116);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtDepartamento.TabIndex = 12;
            // 
            // cargoLabel
            // 
            cargoLabel.AutoSize = true;
            cargoLabel.Location = new System.Drawing.Point(20, 145);
            cargoLabel.Name = "cargoLabel";
            cargoLabel.Size = new System.Drawing.Size(38, 13);
            cargoLabel.TabIndex = 13;
            cargoLabel.Text = "Cargo:";
            // 
            // txtCargo
            // 
            this.txtCargo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Cargo", true));
            this.txtCargo.Location = new System.Drawing.Point(128, 142);
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(100, 20);
            this.txtCargo.TabIndex = 14;
            // 
            // fecha_IngresoLabel
            // 
            fecha_IngresoLabel.AutoSize = true;
            fecha_IngresoLabel.Location = new System.Drawing.Point(20, 171);
            fecha_IngresoLabel.Name = "fecha_IngresoLabel";
            fecha_IngresoLabel.Size = new System.Drawing.Size(78, 13);
            fecha_IngresoLabel.TabIndex = 15;
            fecha_IngresoLabel.Text = "Fecha Ingreso:";
            // 
            // txtFecha
            // 
            this.txtFecha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Fecha_Ingreso", true));
            this.txtFecha.Location = new System.Drawing.Point(128, 168);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 16;
            // 
            // salarioLabel
            // 
            salarioLabel.AutoSize = true;
            salarioLabel.Location = new System.Drawing.Point(20, 197);
            salarioLabel.Name = "salarioLabel";
            salarioLabel.Size = new System.Drawing.Size(42, 13);
            salarioLabel.TabIndex = 17;
            salarioLabel.Text = "Salario:";
            // 
            // txtSalario
            // 
            this.txtSalario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Salario", true));
            this.txtSalario.Location = new System.Drawing.Point(128, 194);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 20);
            this.txtSalario.TabIndex = 18;
            // 
            // estatusLabel
            // 
            estatusLabel.AutoSize = true;
            estatusLabel.Location = new System.Drawing.Point(20, 223);
            estatusLabel.Name = "estatusLabel";
            estatusLabel.Size = new System.Drawing.Size(45, 13);
            estatusLabel.TabIndex = 19;
            estatusLabel.Text = "Estatus:";
            // 
            // txtEstatus
            // 
            this.txtEstatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.empleadosBindingSource, "Estatus", true));
            this.txtEstatus.Location = new System.Drawing.Point(128, 220);
            this.txtEstatus.Name = "txtEstatus";
            this.txtEstatus.Size = new System.Drawing.Size(100, 20);
            this.txtEstatus.TabIndex = 20;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(14, 256);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(99, 31);
            this.btRegistrar.TabIndex = 21;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // btEditar
            // 
            this.btEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditar.Location = new System.Drawing.Point(129, 256);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(99, 31);
            this.btEditar.TabIndex = 22;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = true;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(14, 366);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(99, 31);
            this.btCancelar.TabIndex = 24;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txtEliminar
            // 
            this.txtEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEliminar.Location = new System.Drawing.Point(14, 312);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(99, 31);
            this.txtEliminar.TabIndex = 23;
            this.txtEliminar.Text = "Eliminar";
            this.txtEliminar.UseVisualStyleBackColor = true;
            this.txtEliminar.Click += new System.EventHandler(this.txtEliminar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(128, 312);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(99, 31);
            this.txtBuscar.TabIndex = 25;
            this.txtBuscar.Text = "Buscar";
            this.txtBuscar.UseVisualStyleBackColor = true;
            this.txtBuscar.Click += new System.EventHandler(this.txtBuscar_Click);
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(128, 366);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(99, 31);
            this.btVolver.TabIndex = 26;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // Empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 406);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.btEditar);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(codigo_EmpleadoLabel);
            this.Controls.Add(this.txtcodigoEmpleados);
            this.Controls.Add(nombre_EmpleadoLabel);
            this.Controls.Add(this.txtNombreEmpleados);
            this.Controls.Add(apellido_EmpleadoLabel);
            this.Controls.Add(this.txtApellidoEmpleados);
            this.Controls.Add(telefono_EmpleadoLabel);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(departamentoLabel);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(cargoLabel);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(fecha_IngresoLabel);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(salarioLabel);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(estatusLabel);
            this.Controls.Add(this.txtEstatus);
            this.Controls.Add(this.empleadosDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.Empleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empleadosDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RecursosHumanosDataSet recursosHumanosDataSet;
        private System.Windows.Forms.BindingSource empleadosBindingSource;
        private RecursosHumanosDataSetTableAdapters.EmpleadosTableAdapter empleadosTableAdapter;
        private RecursosHumanosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView empleadosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox txtcodigoEmpleados;
        private System.Windows.Forms.TextBox txtNombreEmpleados;
        private System.Windows.Forms.TextBox txtApellidoEmpleados;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.TextBox txtEstatus;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btEditar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button txtEliminar;
        private System.Windows.Forms.Button txtBuscar;
        private System.Windows.Forms.Button btVolver;
    }
}