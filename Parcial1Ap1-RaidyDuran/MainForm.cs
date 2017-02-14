using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_RaidyDuran
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Registros.EmpleadosRegistroForm().Show();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new UI.Consultas.EmpleadosConsultasForm().Show();
        }
    }
}
