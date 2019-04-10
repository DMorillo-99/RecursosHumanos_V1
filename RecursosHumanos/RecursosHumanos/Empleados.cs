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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void empleadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empleadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.recursosHumanosDataSet);

        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'recursosHumanosDataSet.Empleados' table. You can move, or remove it, as needed.
            this.empleadosTableAdapter.Fill(this.recursosHumanosDataSet.Empleados);
            CargarDatos();
        }

        public void CargarDatos()
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                SqlDataAdapter cargarDatos = new SqlDataAdapter("Select * From Empleados", conn);
                DataTable dt = new DataTable();
                cargarDatos.Fill(dt);
                empleadosDataGridView.DataSource = dt;
                conn.Close();
                BorrarDatos();
            }
        }

        public void BorrarDatos()
        {
            txtcodigoEmpleados.Text = "";
            txtNombreEmpleados.Text = "";
            txtApellidoEmpleados.Text = "";
            txtTelefono.Text = "";
            txtDepartamento.Text = "";
            txtCargo.Text = "";
            txtFecha.Text = "";
            txtSalario.Text = "";
            txtEstatus.Text = "";
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                try 
                {
                    Datos1 de = new Datos1();
                    de.codigoEmpleado = Convert.ToInt32(txtcodigoEmpleados.Text);
                    de.nombreEmpleado = txtNombreEmpleados.Text;
                    de.apellidoEmpleado = txtApellidoEmpleados.Text;
                    de.telefonoEmpleado = txtTelefono.Text;
                    de.departamento = txtDepartamento.Text;
                    de.cargo = txtCargo.Text;
                    de.fechaIngreso = txtFecha.Text;
                    de.salario = Convert.ToInt32(txtSalario.Text);
                    de.estatus = txtEstatus.Text;

                    MantenimientoEmpleados me = new MantenimientoEmpleados();
                    me.RegistrarEmpleado(de);
                    CargarDatos();
                }
                catch(Exception)
                {
                    MessageBox.Show("Ha ocurrido un error el departamento no existe", "Error ");
                }
            }
        }

        private void btEditar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                try
                {
                    Datos1 de = new Datos1();
                    de.codigoEmpleado = Convert.ToInt32(txtcodigoEmpleados.Text);
                    de.nombreEmpleado = txtNombreEmpleados.Text;
                    de.apellidoEmpleado = txtApellidoEmpleados.Text;
                    de.telefonoEmpleado = txtTelefono.Text;
                    de.departamento = txtDepartamento.Text;
                    de.cargo = txtCargo.Text;
                    de.fechaIngreso = txtFecha.Text;
                    de.salario = Convert.ToInt32(txtSalario.Text);
                    de.estatus = txtEstatus.Text;

                    MantenimientoEmpleados me = new MantenimientoEmpleados();
                    me.EditarEmpleado(de);
                    CargarDatos();
                }
                catch(Exception)
                {
                    MessageBox.Show("Ha ocurrido un error", "Error ");
                }
            }
        }

        private void txtEliminar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = Conexion.Conectar())
            {
                try
                {
                    Datos1 de = new Datos1();
                    de.codigoEmpleado = Convert.ToInt32(txtcodigoEmpleados.Text);
                    de.estatus = txtEstatus.Text;

                    MantenimientoEmpleados me = new MantenimientoEmpleados();
                    me.EliminarEmpleado(de);
                    CargarDatos();
                }
                catch (Exception)
                {
                    MessageBox.Show("Ha ocurrido un error", "Error ");
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void txtBuscar_Click(object sender, EventArgs e)
        {
            BuscarEmpleado();
        }
        public void BuscarEmpleado()
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlDataAdapter buscarEmpleado = new SqlDataAdapter("Select * From Empleados Where Codigo_Empleado = '" + Convert.ToInt32(txtcodigoEmpleados.Text) + "'", conn);
                    DataTable dt = new DataTable();
                    buscarEmpleado.Fill(dt);
                    empleadosDataGridView.DataSource = dt;
                    conn.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Error");
            }
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu_Mantenimeinto mm = new Menu_Mantenimeinto();
            mm.Show();
            this.Hide();
        }
    }
}
