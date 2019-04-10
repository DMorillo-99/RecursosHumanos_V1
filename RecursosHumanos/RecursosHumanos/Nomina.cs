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
    public partial class Nomina : Form
    {
        public Nomina()
        {
            InitializeComponent();
        }

        private void nominasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nominasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recursosHumanosDataSet);

        }

        private void Nomina_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Nominas' table. You can move, or remove it, as needed.
            this.nominasTableAdapter.Fill(this.recursosHumanosDataSet.Nominas);
            CargarDatos();
            CalcularNomina();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuProcesos mp = new MenuProcesos();
            mp.Show();
            this.Hide();
        }
        public void BorrarDatos()
        {
            txtAño.Text = "";
            txtMes.Text = "";
            txtMontoTotal.Text = "";
        }

        public void CargarDatos()
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Nominas", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                nominasDataGridView.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        public void CalcularNomina()
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                SqlDataAdapter calcularNomina = new SqlDataAdapter("Select Sum(Salario) as Total From Empleados", conn);
                DataTable dt = new DataTable();
                calcularNomina.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Datos2 d = new Datos2();
            d.fecha1 = txtMes.Text;
            d.fecha2 = txtAño.Text;
            d.montoTotal = Convert.ToInt32(txtMontoTotal.Text);

            FuncionesProcesos fp = new FuncionesProcesos();
            fp.RegistrarNomina(d);
            CargarDatos();
        }
    }
}
