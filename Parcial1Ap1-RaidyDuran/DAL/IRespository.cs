using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Parcial1Ap1_RaidyDuran.DAL
{
    public interface IRespository<TEntity> : IDisposable where TEntity : class
    {
        bool Guardar(TEntity entity);
        TEntity Buscar(Expression<Func<TEntity, bool>> expresion);
        bool Modificar(TEntity entity);
        bool Eliminar(TEntity entity);
        List<TEntity> GetList(Expression<Func<TEntity, bool>> expression);
        List<TEntity> GetListTodo();
    }
}
