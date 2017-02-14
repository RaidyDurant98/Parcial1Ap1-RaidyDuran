using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_RaidyDuran.UI.Consultas
{
    public partial class EmpleadosConsultasForm : Form
    {
        public EmpleadosConsultasForm()
        {
            InitializeComponent();
        }

        private void EmpleadosConsultasForm_Load(object sender, EventArgs e)
        {

        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarConsultacomboBox.SelectedIndex == 0)
            {
                ListadataGridView.DataSource = BLL.EmpleadosBLL.GetListNombre(FiltrarConsultatextBox.Text);
            }
            if (FiltrarConsultacomboBox.SelectedIndex == 1)
            {
                ListadataGridView.DataSource = BLL.EmpleadosBLL.GetListFecha(DesdedateTimePicker.Value.Date, HastadateTimePicker.Value.Date);
            } 
            if (FiltrarConsultacomboBox.SelectedIndex == 2)
            {
                ListadataGridView.DataSource = BLL.EmpleadosBLL.GetList();
            }
        }
    }
}
