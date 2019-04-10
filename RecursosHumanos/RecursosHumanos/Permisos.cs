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
    public partial class Permisos : Form
    {
        public Permisos()
        {
            InitializeComponent();
        }

        private void permisoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.permisoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recursosHumanosDataSet);

        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Permiso' table. You can move, or remove it, as needed.
            this.permisoTableAdapter.Fill(this.recursosHumanosDataSet.Permiso);
            CargarDatos();
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
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Permiso", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                permisoDataGridView.DataSource = dt;
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
            d.comentario = txtComentario.Text;

            FuncionesProcesos fp = new FuncionesProcesos();
            fp.RegistrarPermisos(d);
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
