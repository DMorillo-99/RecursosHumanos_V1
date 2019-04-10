using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecursosHumanos
{
    public partial class ReportesMenu : Form
    {
        public ReportesMenu()
        {
            InitializeComponent();
        }

        private void btNominas_Click(object sender, EventArgs e)
        {
            ReporteNomina rn = new ReporteNomina();
            rn.Show();
            this.Hide();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu1 m = new Menu1();
            m.Show();
            this.Hide();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            Empleadosreport er = new Empleadosreport();
            er.Show();
            this.Hide();
        }

        private void btDepartamentos_Click(object sender, EventArgs e)
        {
            ReportDepartamento rd = new ReportDepartamento();
            rd.Show();
            this.Hide();
        }

        private void btCargos_Click(object sender, EventArgs e)
        {
            ReportCargo1 cr = new ReportCargo1();
            cr.Show();
            this.Hide();
        }

        private void btVacaciones_Click(object sender, EventArgs e)
        {
            ReportVacaciones rv = new ReportVacaciones();
            rv.Show();
            this.Hide();
        }

        private void btLicencia_Click(object sender, EventArgs e)
        {
            ReporteLicencia rl = new ReporteLicencia();
            rl.Show();
            this.Hide();
        }

        private void btPermisos_Click(object sender, EventArgs e)
        {
            PermisoReport pr = new PermisoReport();
            pr.Show();
            this.Hide();
        }
    }
}
