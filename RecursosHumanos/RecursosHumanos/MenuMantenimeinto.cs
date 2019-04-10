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
    public partial class Menu_Mantenimeinto : Form
    {
        public Menu_Mantenimeinto()
        {
            InitializeComponent();
        }

        private void btEmpleados_Click(object sender, EventArgs e)
        {
            Empleados es = new Empleados();
            es.Show();
            this.Hide();

        }

        private void btDepartamentos_Click(object sender, EventArgs e)
        {
            Departamentos d = new Departamentos();
            d.Show();
            this.Hide();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            Menu1 m = new Menu1();
            m.Show();
            this.Hide();
        }

        private void btCargo_Click(object sender, EventArgs e)
        {
            Cargo c = new Cargo();
            c.Show();
            this.Hide();
        }
    }
}
