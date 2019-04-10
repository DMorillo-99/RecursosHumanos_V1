namespace RecursosHumanos
{
    partial class Nomina
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
            System.Windows.Forms.Label mesLabel;
            System.Windows.Forms.Label añoLabel;
            System.Windows.Forms.Label monto_TotalLabel;
            this.recursosHumanosDataSet = new RecursosHumanos.RecursosHumanosDataSet();
            this.nominasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nominasTableAdapter = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.NominasTableAdapter();
            this.tableAdapterManager = new RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager();
            this.nominasDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btVolver = new System.Windows.Forms.Button();
            mesLabel = new System.Windows.Forms.Label();
            añoLabel = new System.Windows.Forms.Label();
            monto_TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // recursosHumanosDataSet
            // 
            this.recursosHumanosDataSet.DataSetName = "RecursosHumanosDataSet";
            this.recursosHumanosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nominasBindingSource
            // 
            this.nominasBindingSource.DataMember = "Nominas";
            this.nominasBindingSource.DataSource = this.recursosHumanosDataSet;
            // 
            // nominasTableAdapter
            // 
            this.nominasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CargoTableAdapter = null;
            this.tableAdapterManager.DepartamentosTableAdapter = null;
            this.tableAdapterManager.EmpleadosTableAdapter = null;
            this.tableAdapterManager.LicenciaTableAdapter = null;
            this.tableAdapterManager.NominasTableAdapter = this.nominasTableAdapter;
            this.tableAdapterManager.PermisoTableAdapter = null;
            this.tableAdapterManager.SalidaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = RecursosHumanos.RecursosHumanosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VacacionesTableAdapter = null;
            // 
            // nominasDataGridView
            // 
            this.nominasDataGridView.AutoGenerateColumns = false;
            this.nominasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.nominasDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.nominasDataGridView.DataSource = this.nominasBindingSource;
            this.nominasDataGridView.Location = new System.Drawing.Point(196, 12);
            this.nominasDataGridView.Name = "nominasDataGridView";
            this.nominasDataGridView.Size = new System.Drawing.Size(444, 242);
            this.nominasDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id_Nomina";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id_Nomina";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Mes";
            this.dataGridViewTextBoxColumn2.HeaderText = "Mes";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Año";
            this.dataGridViewTextBoxColumn3.HeaderText = "Año";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Monto_Total";
            this.dataGridViewTextBoxColumn4.HeaderText = "Monto_Total";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // mesLabel
            // 
            mesLabel.AutoSize = true;
            mesLabel.Location = new System.Drawing.Point(17, 15);
            mesLabel.Name = "mesLabel";
            mesLabel.Size = new System.Drawing.Size(30, 13);
            mesLabel.TabIndex = 3;
            mesLabel.Text = "Mes:";
            // 
            // txtMes
            // 
            this.txtMes.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "Mes", true));
            this.txtMes.Location = new System.Drawing.Point(90, 12);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(100, 20);
            this.txtMes.TabIndex = 4;
            // 
            // añoLabel
            // 
            añoLabel.AutoSize = true;
            añoLabel.Location = new System.Drawing.Point(17, 41);
            añoLabel.Name = "añoLabel";
            añoLabel.Size = new System.Drawing.Size(29, 13);
            añoLabel.TabIndex = 5;
            añoLabel.Text = "Año:";
            // 
            // txtAño
            // 
            this.txtAño.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "Año", true));
            this.txtAño.Location = new System.Drawing.Point(90, 38);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(100, 20);
            this.txtAño.TabIndex = 6;
            // 
            // monto_TotalLabel
            // 
            monto_TotalLabel.AutoSize = true;
            monto_TotalLabel.Location = new System.Drawing.Point(17, 67);
            monto_TotalLabel.Name = "monto_TotalLabel";
            monto_TotalLabel.Size = new System.Drawing.Size(67, 13);
            monto_TotalLabel.TabIndex = 7;
            monto_TotalLabel.Text = "Monto Total:";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.nominasBindingSource, "Monto_Total", true));
            this.txtMontoTotal.Location = new System.Drawing.Point(90, 64);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtMontoTotal.TabIndex = 8;
            // 
            // btRegistrar
            // 
            this.btRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistrar.Location = new System.Drawing.Point(30, 173);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(135, 31);
            this.btRegistrar.TabIndex = 9;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(170, 77);
            this.dataGridView1.TabIndex = 10;
            // 
            // btVolver
            // 
            this.btVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVolver.Location = new System.Drawing.Point(30, 223);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(135, 31);
            this.btVolver.TabIndex = 11;
            this.btVolver.Text = "Volver";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // Nomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 270);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btRegistrar);
            this.Controls.Add(mesLabel);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(añoLabel);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(monto_TotalLabel);
            this.Controls.Add(this.txtMontoTotal);
            this.Controls.Add(this.nominasDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Nomina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nomina";
            this.Load += new System.EventHandler(this.Nomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.recursosHumanosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nominasDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RecursosHumanosDataSet recursosHumanosDataSet;
        private System.Windows.Forms.BindingSource nominasBindingSource;
        private RecursosHumanosDataSetTableAdapters.NominasTableAdapter nominasTableAdapter;
        private RecursosHumanosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView nominasDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.TextBox txtMontoTotal;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btVolver;
    }
}