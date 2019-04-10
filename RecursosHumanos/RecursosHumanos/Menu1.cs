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
    public partial class Menu1 : Form
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void btMantenimientos_Click(object sender, EventArgs e)
        {
            Menu_Mantenimeinto mm = new Menu_Mantenimeinto();
            mm.Show();
            this.Hide();
        }

        private void btProcesos_Click(object sender, EventArgs e)
        {
            MenuProcesos mp = new MenuProcesos();
            mp.Show();
            this.Hide();
        }

        private void btReportes_Click(object sender, EventArgs e)
        {
            ReportesMenu rm = new ReportesMenu();
            rm.Show();
            this.Hide();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
