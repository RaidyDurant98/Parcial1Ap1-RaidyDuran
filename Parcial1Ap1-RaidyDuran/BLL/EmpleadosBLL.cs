using Parcial1Ap1_RaidyDuran.DAL;
using Parcial1Ap1_RaidyDuran.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Parcial1Ap1_RaidyDuran.BLL
{
    public class EmpleadosBLL
    {
        public static bool Guardar(Empleados empleado)
        {
            bool interruptor = false;

            using(var conec = new Parcial1Db())
            {
                try
                {
                    if(Buscar(empleado.EmpleadoId) == null)
                    {
                        conec.Empleado.Add(empleado);
                        conec.SaveChanges();
                        interruptor = true;
                    }
                    else
                    {
                        conec.Entry(empleado).State = EntityState.Modified;
                        conec.SaveChanges();
                        interruptor = true;
                    }
                }
                catch (Exception)
                {

                    throw;
                }

                return interruptor;
            }
        }

        public static Empleados Buscar(int id)
        {
            var buscar = new Empleados();

            using (var conec = new Parcial1Db())
            {
                try
                {
                    buscar = conec.Empleado.Find(id);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return buscar;
        }

        public static bool Eliminar(Empleados empleado)
        {
            bool interruptor = false;

            using (var conec = new Parcial1Db())
            {
                try
                {
                    conec.Entry(empleado).State = EntityState.Deleted;
                    conec.SaveChanges();
                    interruptor = true;
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return interruptor;
        }

        public static List<Empleados> GetListFecha(DateTime desde, DateTime hasta)
        {
            var list = new List<Empleados>();

            using (var conec = new Parcial1Db())
            {
                try
                {
                    list = conec.Empleado.Where(p => p.FechaNacimiento >= desde.Date && p.FechaNacimiento <= hasta.Date).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return list;
        }

        public static List<Empleados> GetListNombre(string nombre)
        {
            var list = new List<Empleados>();

            using (var conec = new Parcial1Db())
            {
                try
                {
                    list = conec.Empleado.Where(p => p.Nombre == nombre).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return list;
        }

        public static List<Empleados> GetList()
        {
            var list = new List<Empleados>();

            using(var conec = new Parcial1Db())
            {
                try
                {
                    list = conec.Empleado.ToList();
                }
                catch (Exception)
                {

                    throw;
                }
            }

            return list;
        }
    }
}
