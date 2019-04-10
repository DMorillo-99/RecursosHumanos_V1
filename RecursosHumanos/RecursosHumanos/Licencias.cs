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
    public partial class Licencias : Form
    {
        public Licencias()
        {
            InitializeComponent();
        }

        private void licenciaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.licenciaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recursosHumanosDataSet);

        }

        private void Licencias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Licencia' table. You can move, or remove it, as needed.
            this.licenciaTableAdapter.Fill(this.recursosHumanosDataSet.Licencia);

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
            using (SqlConnection conn = Conexion.Conectar())
            {
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Licencia", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                licenciaDataGridView.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            Datos2 d = new Datos2();
            d.codigoEmpleado = Convert.ToInt32(txtCodigoEmpleado.Text);
            d.fecha1 = txtInicioFecha.Text;
            d.fecha2 = txtFinFecha.Text;
            d.año = txtAño.Text;
            d.motivo = txtMotivo.Text;
            d.comentario = txtComentario.Text;

            FuncionesProcesos fp = new FuncionesProcesos();
            fp.RegistrarLicencias(d);
            CargarDatos();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            MenuProcesos mp = new MenuProcesos();
            mp.Show();
            this.Hide();
        }
    }
}
