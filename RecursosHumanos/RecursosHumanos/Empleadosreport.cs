﻿using System;
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
    public partial class Empleadosreport : Form
    {
        public Empleadosreport()
        {
            InitializeComponent();
        }

        private void btVolver_Click(object sender, EventArgs e)
        {
            ReportesMenu rm = new ReportesMenu();
            rm.Show();
            this.Hide();
        }
    }
}
