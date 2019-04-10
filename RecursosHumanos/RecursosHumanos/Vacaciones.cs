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
    public partial class Vacaciones : Form
    {
        public Vacaciones()
        {
            InitializeComponent();
        }

        private void vacacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recursosHumanosDataSet);

        }

        private void Vacaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Vacaciones' table. You can move, or remove it, as needed.
            this.vacacionesTableAdapter.Fill(this.recursosHumanosDataSet.Vacaciones);

        }

        public void BorrarDatos()
        {
            txtAño.Text = "";
            txtCodigoEmpleado.Text = "";
            txtComentario.Text = "";
            txtFinFecha.Text = "";
            txtInicioFecha.Text = "";
        }
        public void CargarDatos()
        {
            using (SqlConnection conn =  Conexion.Conectar())
            {
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Vacaciones", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                vacacionesDataGridView.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuProcesos mp = new MenuProcesos();
            mp.Show();
            this.Hide();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Datos2 d = new Datos2();
            d.codigoEmpleado = Convert.ToInt32(txtCodigoEmpleado.Text);
            d.fecha1 = txtInicioFecha.Text;
            d.fecha2 = txtFinFecha.Text;
            d.año = txtAño.Text;
            d.comentario = txtComentario.Text;

            FuncionesProcesos fp = new FuncionesProcesos();
            fp.RegistrarVacaciones(d);
            CargarDatos();
        }
    }
}
