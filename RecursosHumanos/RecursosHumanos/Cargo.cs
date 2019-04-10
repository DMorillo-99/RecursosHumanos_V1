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
    public partial class Cargo : Form
    {
        public Cargo()
        {
            InitializeComponent();
        }

        private void cargoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cargoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recursosHumanosDataSet);

        }

        private void Cargo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Cargo' table. You can move, or remove it, as needed.
            this.cargoTableAdapter.Fill(this.recursosHumanosDataSet.Cargo);
            CargarDatos();
        }

        public void CargarDatos()
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Cargo", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                cargoDataGridView.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        public void BorrarDatos()
        {
            txtCargo.Text = "";
            txtcodigoCargo.Text = "";
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Datos1 d = new Datos1();
            d.codigoCargo = Convert.ToInt32(txtcodigoCargo.Text);
            d.nombrecargo = txtCargo.Text;
            MantenimientoCargo mc = new MantenimientoCargo();
            mc.RegistrarCargo(d);
            CargarDatos();
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            Datos1 d = new Datos1();
            d.codigoCargo = Convert.ToInt32(txtcodigoCargo.Text);
            d.nombrecargo = txtCargo.Text;
            MantenimientoCargo mc = new MantenimientoCargo();
            mc.EditarCargo(d);
            CargarDatos();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            Datos1 d = new Datos1();
            d.codigoCargo = Convert.ToInt32(txtcodigoCargo.Text);
            MantenimientoCargo mc = new MantenimientoCargo();
            mc.EliminarCargo(d);
            CargarDatos();
        }

        private void btBuscar_Click(object sender, EventArgs e)
        {
            BuscarCargo();
        }

        public void BuscarCargo()
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlDataAdapter buscarEmpleado = new SqlDataAdapter("Select * From Cargo Where Codigo_Cargo = '" + Convert.ToInt32(txtcodigoCargo.Text) + "'", conn);
                    DataTable dt = new DataTable();
                    buscarEmpleado.Fill(dt);
                    cargoDataGridView.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error");
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu_Mantenimeinto mm = new Menu_Mantenimeinto();
            mm.Show();
            this.Hide();
        }
    }
}
