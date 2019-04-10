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
    public partial class MenuProcesos : Form
    {
        public MenuProcesos()
        {
            InitializeComponent();
        }

        private void btNomina_Click(object sender, EventArgs e)
        {
            Nomina n = new Nomina();
            n.Show();
            this.Hide();
        }

        private void btVacaciones_Click(object sender, EventArgs e)
        {
            Vacaciones v = new Vacaciones();
            v.Show();
            this.Hide();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu1 m = new Menu1();
            m.Show();
            this.Hide();
        }

        private void btPermisos_Click(object sender, EventArgs e)
        {
            Permisos p = new Permisos();
            p.Show();
            this.Hide();
        }

        private void btLicencias_Click(object sender, EventArgs e)
        {
            Licencias l = new Licencias();
            l.Show();
            this.Hide();
        }
    }
}
