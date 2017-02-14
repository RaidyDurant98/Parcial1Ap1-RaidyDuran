using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_RaidyDuran.Entidades
{
    public class Empleados
    {
        [Key]
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Sueldo { get; set; }
    }
}
