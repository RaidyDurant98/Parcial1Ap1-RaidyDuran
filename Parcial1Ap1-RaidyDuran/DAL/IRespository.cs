using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Parcial1Ap1_RaidyDuran.DAL
{
    public interface IRespository<TEntity> : IDisposable where TEntity : class
    {
        bool Guardar(TEntity laEntidad);
        TEntity Buscar(Expression<Func<TEntity, bool>> criterioBusqueda);
        bool Modificar(TEntity laEntidad);
        bool Eliminar(TEntity laEntidad);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> criterioBusqueda);
        List<TEntity> GetListTodo();
    }
}
