using Parcial1Ap1_RaidyDuran.Entidades;
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

        private bool Validar()
        {
            if (string.IsNullOrEmpty(FiltrarConsultatextBox.Text))
            {
                FiltrarerrorProvider.SetError(FiltrarConsultatextBox, "Por favor llenar campos.");
                return true;
            }

            return false;
        }

        private void EmpleadosConsultasForm_Load(object sender, EventArgs e)
        {

        }

        private void Filtrarbutton_Click(object sender, EventArgs e)
        {
            using(var context = new DAL.Respository<Empleados>())
            {
                if (FiltrarConsultacomboBox.SelectedIndex == 0)
                {
                    if (!Validar())
                        ListadataGridView.DataSource = context.GetList(p => p.Nombre == FiltrarConsultatextBox.Text);
                    else
                        MessageBox.Show("Por favor digite el nombre que desea consultar.");

                    FiltrarerrorProvider.Clear();
                }
                if (FiltrarConsultacomboBox.SelectedIndex == 1)
                {
                    ListadataGridView.DataSource = context.GetList(x => x.FechaNacimiento >= DesdedateTimePicker.Value.Date && x.FechaNacimiento <= HastadateTimePicker.Value.Date);
                }
                if (FiltrarConsultacomboBox.SelectedIndex == 2)
                {
                    ListadataGridView.DataSource = context.GetListTodo();
                }
            }
        }
    }
}
