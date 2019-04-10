using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RecursosHumanos
{
    class MantenimientoCargo
    {
        public void RegistrarCargo(Datos1 dd)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand registrar = new SqlCommand(string.Format("Insert into Cargo " +
                        "(Codigo_Cargo, " +
                        "Cargo) " +
                            "values ('{0}', '{1}')" +
                            "", dd.codigoCargo, dd.nombrecargo), conn);
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

        public void EliminarCargo(Datos1 dd)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand borrarCargo = new SqlCommand(string.Format("Delete From Cargo Where Codigo_Cargo = '" + dd.codigoCargo + "'"), conn);
                    borrarCargo.ExecuteNonQuery();
                    conn.Close();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error", "Error " + e.Message);
            }
        }

        public void EditarCargo(Datos1 dd)
        {
            try
            {
                using (SqlConnection conn = Conexion.Conectar())
                {
                    SqlCommand editarcargo = new SqlCommand(string.Format("Update Cargo " +
                        "Set " +
                        "Codigo_Cargo = '" + dd.codigoCargo + "'" +
                        ", Cargo = '" + dd.nombrecargo + "'" +
                        "Where Codigo_Cargo = '" + dd.codigoCargo + "'"), conn);
                    editarcargo.ExecuteNonQuery();
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

