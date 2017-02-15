using Parcial1Ap1_RaidyDuran.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Parcial1Ap1_RaidyDuran.DAL
{
    public class Respository<TEntity> : IRespository<TEntity> where TEntity : class
    {
        Parcial1Db Context = null;

        public Respository()
        {
            Context = new Parcial1Db();
        }

        private DbSet<TEntity> EntitySet
        {
            get
            {
                return Context.Set<TEntity>();
            }
        }

        public TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.FirstOrDefault(criterioBusqueda);
            }
            catch { }

            return null;
        }

        public bool Eliminar(TEntity laEntidad)
        {
            try
            {
                EntitySet.Attach(laEntidad);
                EntitySet.Remove(laEntidad);
                return Context.SaveChanges() > 0;
            }
            catch { }

            return false;
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda)
        {
            try
            {
                return EntitySet.Where(criterioBusqueda).ToList();
            }
            catch { }

            return null;
        }

        public List<TEntity> GetListTodo()
        {
            try
            {
                return EntitySet.ToList();
            }
            catch { }

            return null;
        }

        public bool Guardar(TEntity criterioBusqueda)
        {
            try
            {   
                EntitySet.Add(criterioBusqueda);
                Context.SaveChanges();
                return true;
            }
            catch { }

            return false;
        }

        public bool Modificar(TEntity laEntidad)
        {
            try
            {
                EntitySet.Attach(laEntidad);

                Context.Entry<TEntity>(laEntidad).State = EntityState.Modified;

                return Context.SaveChanges() > 0;
            }
            catch { }

            return false;
        }

        public void Dispose()
        {
            if (Context != null)
                Context.Dispose();
        }
    }
}
