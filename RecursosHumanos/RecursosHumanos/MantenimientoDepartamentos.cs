using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace RecursosHumanos
{
    class MantenimientoDepartamentos
    {
        public void RegistrarDepartamento(Datos1 dd)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand registrar = new SqlCommand(string.Format("Insert into Departamentos " +
                        "(Codigo_Departamento, " +
                        "Nombre_Departamento, " +
                        "Encargado) " +
                            "values ('{0}', '{1}', '{2}')" +
                            "", dd.codigoDepartamento, dd.nombreDepartamento, dd.encargado), conn);
                    registrar.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Los datos se han registrador correstamente", "Registrado Correcto");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", "Error" + e.Message);

            }
        }

        public void EliminarDepartamento(Datos1 dd)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand borrarEmpleados = new SqlCommand(string.Format("Delete From Departamentos Where Codigo_Departamento = '" + dd.codigoDepartamento + "'"), conn);
                    borrarEmpleados.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", "Error " + e.Message);
            }
        }

        public void EditarDespartamento(Datos1 dd)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand editarEmpleados = new SqlCommand(string.Format("Update Departamentos " +
                        "Set " +
                        "Codigo_Departamento = '" + dd.codigoDepartamento + "'" +
                        ", Nombre_Departamento = '" + dd.nombreDepartamento + "'" +
                        ", Encargado = '" + dd.encargado + "'" +
                        "Where Codigo_Departamento = '" + dd.codigoDepartamento + "'"), conn);
                    editarEmpleados.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", "Error " + e.Message);
            }
        }
    }
}
