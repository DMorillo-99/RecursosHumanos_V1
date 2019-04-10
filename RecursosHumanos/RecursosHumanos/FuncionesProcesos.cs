using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RecursosHumanos
{
    class FuncionesProcesos
    {
        public void RegistrarNomina( Datos2 de)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand registrar = new SqlCommand(string.Format("Insert into Nominas" +
                        "(Mes, " +
                        "Año, " +
                        "Monto_Total) " +
                            "values ('{0}', '{1}', '{2}')" +
                            "", de.fecha1, de.fecha2, de.montoTotal), conn);
                    registrar.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Ha ocurrido un error" , "Error " + s.Message);
            }
        }

        public void RegistrarVacaciones(Datos2 de)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand registrar = new SqlCommand(string.Format("Insert into Vacaciones" +
                        "(Codigo_Empleado, " +
                        "Inicio_Fecha," +
                        "Fin_Fecha," +
                        "Año, " +
                        "Comentario) " +
                            "values ('{0}', '{1}', '{2}', '{3}', '{4}')" +
                            "", de.codigoEmpleado, de.fecha1, de.fecha2, de.año, de.comentario), conn);
                    registrar.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Ha ocurrido un error", "Error " + s.Message);
            }
        }

        public void RegistrarPermisos(Datos2 de)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand registrar = new SqlCommand(string.Format("Insert into Permiso" +
                        "(Codigo_Empleado, " +
                        "Inicio_Fecha," +
                        "Fin_Fecha," +
                        "Año, " +
                        "Comentario) " +
                            "values ('{0}', '{1}', '{2}', '{3}', '{4}')" +
                            "", de.codigoEmpleado, de.fecha1, de.fecha2, de.año, de.comentario), conn);
                    registrar.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Ha ocurrido un error", "Error " + s.Message);
            }
        }

        public void RegistrarLicencias(Datos2 de)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand registrar = new SqlCommand(string.Format("Insert into Licencia" +
                        "(Codigo_Empleado, " +
                        "Inicio_Fecha," +
                        "Fin_Fecha," +
                        "Año," +
                        "Motivo, " +
                        "Comentario) " +
                            "values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')" +
                            "", de.codigoEmpleado, de.fecha1, de.fecha2, de.año, de.motivo, de.comentario), conn);
                    registrar.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception s)
            {
                MessageBox.Show("Ha ocurrido un error", "Error " + s.Message);
            }
        }
    }
}
