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
    public partial class ReporteNomina : Form
    {
        public ReporteNomina()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            ReportesMenu m = new ReportesMenu();
            m.Show();
            this.Hide();
        }
    }
}
