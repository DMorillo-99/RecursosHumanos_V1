using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos
{
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void departamentosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.departamentosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recursosHumanosDataSet);

        }

        private void Departamentos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.recursosHumanosDataSet.Departamentos);
            CargarDatos();
        }

        public void CargarDatos()
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Departamentos", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                departamentosDataGridView.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        public void BorrarDatos()
        {
            txtCodigoDepartamento.Text = "";
            txtEncargado.Text = "";
            txtnombre.Text = "";
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu_Mantenimeinto mm = new Menu_Mantenimeinto();
            mm.Show();
            this.Hide();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Datos1 dd = new Datos1();
            dd.codigoDepartamento = txtCodigoDepartamento.Text;
            dd.nombreDepartamento = txtnombre.Text;
            dd.encargado = txtEncargado.Text;
            MantenimientoDepartamentos md = new MantenimientoDepartamentos();
            md.RegistrarDepartamento(dd);
            CargarDatos();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Departamentos Where Codigo_Departamento = '" + txtCodigoDepartamento.Text + "'", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                departamentosDataGridView.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Datos1 dd = new Datos1();
            dd.codigoDepartamento = txtCodigoDepartamento.Text;
            dd.nombreDepartamento = txtnombre.Text;
            dd.encargado = txtEncargado.Text;
            MantenimientoDepartamentos md = new MantenimientoDepartamentos();
            md.EditarDespartamento(dd);
            CargarDatos();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Datos1 dd = new Datos1();
            dd.codigoDepartamento = txtCodigoDepartamento.Text;
            MantenimientoDepartamentos md = new MantenimientoDepartamentos();
            md.EliminarDepartamento(dd);
            CargarDatos();
        }
    }
}
