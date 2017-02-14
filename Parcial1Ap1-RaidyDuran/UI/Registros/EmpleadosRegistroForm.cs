using Parcial1Ap1_RaidyDuran.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Parcial1Ap1_RaidyDuran.UI.Registros
{
    public partial class EmpleadosRegistroForm : Form
    {
        public EmpleadosRegistroForm()
        {
            InitializeComponent();
        }

        private void EmpleadosRegistroForm_Load(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            empleadoIdTextBox.Clear();
            nombreTextBox.Clear();
            fechaNacimientoDateTimePicker.Value = DateTime.Today;
            nombreTextBox.Focus();
            NombreerrorProvider.Clear();
            sueldomaskedTextBox.Clear();
            SueldoerrorProvider.Clear();
        }

        private bool Validar()
        {
            bool interruptor = true;

            if (string.IsNullOrEmpty(nombreTextBox.Text))
            {
                NombreerrorProvider.SetError(nombreTextBox, "Por favor digite su nombre.");
                interruptor = false;
            }
            if (string.IsNullOrEmpty(sueldomaskedTextBox.Text))
            {
                SueldoerrorProvider.SetError(sueldomaskedTextBox, "Por favor digite su sueldo.");
                interruptor = false;
            }

            return interruptor;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            var guardar = new Empleados();

            if (!Validar())
            {
                MessageBox.Show("Por favor llenar todos los campos.");
            }
            else 
            {
                guardar.Nombre = nombreTextBox.Text;
                guardar.Sueldo = Convert.ToDouble(sueldomaskedTextBox.Text);
                guardar.FechaNacimiento = fechaNacimientoDateTimePicker.Value;

                if (BLL.EmpleadosBLL.Guardar(guardar))
                    MessageBox.Show("El empleado se guardo con exito.");
            }

            Limpiar();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            var buscar = BLL.EmpleadosBLL.Buscar(Utilidades.TOINT(empleadoIdTextBox.Text));

            if (buscar != null)
            {
                nombreTextBox.Text = buscar.Nombre;
                sueldomaskedTextBox.Text = buscar.Sueldo.ToString();
                fechaNacimientoDateTimePicker.Value = buscar.FechaNacimiento;
            }
            else
            {
                MessageBox.Show("No existe ningun empleado con ese Id.");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            var eliminar = BLL.EmpleadosBLL.Buscar(Utilidades.TOINT(empleadoIdTextBox.Text));

            if (eliminar != null)
            {
                BLL.EmpleadosBLL.Eliminar(eliminar);
                MessageBox.Show("El empleado se elimino con exito.");
                Limpiar();
            }
            else
            {
                MessageBox.Show("No se pudo eliminar el empleado.");
            }
        }
    }
}
