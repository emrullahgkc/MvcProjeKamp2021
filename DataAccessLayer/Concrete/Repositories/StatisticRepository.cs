using DataAccessLayer.Abstrack;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class StatisticRepository<T> : IStatisticDal<T> where T : class
    {
        Context c = new Context();
        DbSet<T> _object;
        public StatisticRepository()
        {
            _object = c.Set<T>();
        }

        public int Count(Expression<Func<T, int?>> deger)
        {
            return _object.Count();
        }

        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();  
        }

        public List<T> GetAll()
        {
            return _object.ToList();
        }

        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, TResult>> select)
        {
            return _object.Select(select).Cast<TResult>();

        }
 
        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select)
        {
            return _object.Where(predicate).Select(select).Cast<TResult>();

        }

        //public IQueryable<TResult> GetTop<TResult>(Expression<Func<T, TResult>> select, Expression<Func<T, TResult>> name)
        //{
        //    string sql = "select top 1 count(h.CategoryID) san, c.CategoryName from Headings h INNER JOIN Categories c on c.CategoryID=h.CategoryID group by c.CategoryName order by san desc";
        //    return c.Database.SqlQuery<TResult>(sql).AsQueryable() ;
        //}

     

        public decimal Max(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column)
        {
            return c.Set<T>().Where(predicate).Max(column) ;        }

        public int? Max(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return c.Set<T>().Where(predicate).Max(column);
        }

        public decimal Min(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column)
        {
            return c.Set<T>().Where(predicate).Min(column);
        }

        public int? Min(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return c.Set<T>().Where(predicate).Min(column);
        }

        public decimal Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal?>> column)
        {
            return c.Set<T>().Where(predicate).Sum(column)??0;
        }

        public int? Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return c.Set<T>().Where(predicate).Sum(column ) ;
        }
    }
}
