using Parcial1Ap1_RaidyDuran.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_RaidyDuran.DAL
{
    public class Parcial1Db :DbContext
    {
        public Parcial1Db() : base("ConStr")
        {

        }

        public DbSet<Empleados> Empleado { get; set; }
    }
}
