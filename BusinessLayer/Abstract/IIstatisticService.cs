using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
  public  interface IIstatisticService<T>
    {
        decimal Max(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column);
        decimal Min(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column);
        int? Max(Expression<Func<T, bool>> predicate, Expression<Func<T, Nullable<int>>> column);
        int? Min(Expression<Func<T, bool>> predicate, Expression<Func<T, Nullable<int>>> column);
        decimal Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, Nullable<decimal>>> column);
        int? Sum(Expression<Func<T, bool>> predicate,Expression<Func<T, Nullable<int>>>column);
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> filter);

       
    }
}
