using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RecursosHumanos
{
    class MantenimientoEmpleados
    {
        public void RegistrarEmpleado(Datos1 de)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand registrar = new SqlCommand(string.Format("Insert into Empleados " +
                        "(Codigo_Empleado, " +
                        "Nombre_Empleado, " +
                        "Apellido_Empleado, " +
                        "Telefono_Empleado, " +
                        "Departamento, " +
                        "Cargo, " +
                        "Fecha_Ingreso, " +
                        "Salario, " +
                        "Estatus) " +
                            "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}')" +
                            "", de.codigoEmpleado, de.nombreEmpleado, de.apellidoEmpleado, de.telefonoEmpleado, de.departamento, de.cargo, de.fechaIngreso, de.salario, de.estatus), conn);
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

        public void EliminarEmpleado(Datos1 de)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand eliminarEmpleados = new SqlCommand(string.Format("Update Empleados " +
                        "Set " +
                        "Estatus = 'Inactivo' " +
                        "Where Codigo_Empleado = '" + de.codigoEmpleado + "'"), conn);
                    eliminarEmpleados.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", "Error " + e.Message);
            }
        }

        public void EditarEmpleado(Datos1 de)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand editarEmpleados = new SqlCommand(string.Format("Update Empleados " +
                        "Set " +
                        "Codigo_Empleado = '" + de.codigoEmpleado + "'" +
                        ", Nombre_Empleado = '" + de.nombreEmpleado + "'" +
                        ", Apellido_Empleado = '" + de.apellidoEmpleado + "'  " +
                        ", Telefono_Empleado = '" + de.telefonoEmpleado + "' " +
                        ", Departamento ='" + de.departamento + "' " +
                        ", Cargo = '" + de.cargo + "' " +
                        ", Fecha_Ingreso = '" + de.fechaIngreso + "' " +
                        ", Salario = '" + de.salario + "' " +
                        ", Estatus = '" + de.estatus + "' " +
                        "Where Codigo_Empleado = '" + de.codigoEmpleado + "'"), conn);
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

