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

        public void Limpiar()
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
            int id = 0;

            using (var context = new DAL.Respository<Empleados>())
            {
                if (!Validar())
                {
                    MessageBox.Show("Por favor llenar todos los campos.");
                }
                else
                {
                    guardar.Nombre = nombreTextBox.Text;
                    guardar.Sueldo = Convert.ToDouble(sueldomaskedTextBox.Text);
                    guardar.FechaNacimiento = fechaNacimientoDateTimePicker.Value;
                    guardar.EmpleadoId = Utilidades.TOINT(empleadoIdTextBox.Text);

                    if(id != guardar.EmpleadoId)
                    {
                        context.Modificar(guardar);
                        MessageBox.Show("El empleado se modifico con exito.");
                    }
                    else if(context.Guardar(guardar))
                        MessageBox.Show("El empleado se guardo con exito.");
                }
            }

            Limpiar();
        }

        private void buscarbutton_Click(object sender, EventArgs e)
        {
            var buscar = new Empleados();
            int id = Utilidades.TOINT(empleadoIdTextBox.Text);

            using (var context = new DAL.Respository<Empleados>())
            {
                buscar = context.Buscar(p => p.EmpleadoId == id);
            }

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
            int id = Utilidades.TOINT(empleadoIdTextBox.Text);

            using (var context = new DAL.Respository<Empleados>())
            {
                if (context.Eliminar(context.Buscar(p => p.EmpleadoId == id)))
                {
                    Limpiar();
                    MessageBox.Show("El empleado se elimino con exito.");                  
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el empleado.");
                }
            }


        }
    }
}
