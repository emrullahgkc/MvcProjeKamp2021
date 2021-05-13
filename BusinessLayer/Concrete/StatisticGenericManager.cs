using BusinessLayer.Abstract;
using DataAccessLayer.Abstrack;
using DataAccessLayer.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class StatisticGenericManager<T> : IStatisticService<T> where T : class
    {
        IStatisticDal<T> _StatisticDAL;

  
        public StatisticGenericManager(IStatisticDal<T> statisticDAL)
        {
            _StatisticDAL = statisticDAL;
        }

     
     
        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _StatisticDAL.GetAll(filter);
        }

        public List<T> GetAll()
        {
         return _StatisticDAL.GetAll();
        }

        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, TResult>> select)
        {
            return _StatisticDAL.GetAllSelect(select);  
        }

        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select)
        {
            return _StatisticDAL.GetAllSelect(predicate,select);
        }

  
      

        public decimal Max(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column)
        {
            return _StatisticDAL.Max(predicate, column);       
        }

        public int? Max(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return _StatisticDAL.Max(predicate, column);
        }

        public decimal Min(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column)
        {
            return _StatisticDAL.Min(predicate, column);
        }

        public int? Min(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return _StatisticDAL.Min(predicate, column);
        }

        public decimal Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal?>> column)
        {
            return _StatisticDAL.Sum(predicate, column);
        }

        public int? Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return _StatisticDAL.Sum(predicate, column ) ;
        }
    }
}
