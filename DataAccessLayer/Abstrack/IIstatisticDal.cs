using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstrack
{
   public  interface IIstatisticDal<T>
    {
        decimal Max(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column);
        decimal Min(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column);
        int? Max(Expression<Func<T, bool>> predicate, Expression<Func<T, Nullable<int>>> column);
        int? Min(Expression<Func<T, bool>> predicate, Expression<Func<T, Nullable<int>>> column);
        decimal Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, Nullable<decimal>>> column);
        int? Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, Nullable<int>>> column);
        int Count(Expression<Func<T, Nullable<int>>> deger);

        List<T> GetAll();
        //IQueryable<TResult> GetTop<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, TResult>> name);

        List<T> GetAll(Expression<Func<T, bool>> filter);
        IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, TResult>> select);
        IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select);     
      }
}
