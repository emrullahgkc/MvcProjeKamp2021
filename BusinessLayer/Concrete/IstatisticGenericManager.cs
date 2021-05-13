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
    public class IstatisticGenericManager<T> : IIstatisticService<T> where T : class
    {
        IIstatisticDal<T> _istatisticDAL;

  
        public IstatisticGenericManager(IIstatisticDal<T> istatisticDAL)
        {
            _istatisticDAL = istatisticDAL;
        }

     
     
        public List<T> GetAll(Expression<Func<T, bool>> filter)
        {
            return _istatisticDAL.GetAll(filter);
        }

        public List<T> GetAll()
        {
         return _istatisticDAL.GetAll();
        }

        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, TResult>> select)
        {
            return _istatisticDAL.GetAllSelect(select);  
        }

        public IQueryable<TResult> GetAllSelect<TResult>(Expression<Func<T, bool>> predicate, Expression<Func<T, TResult>> select)
        {
            return _istatisticDAL.GetAllSelect(predicate,select);
        }

  
      

        public decimal Max(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column)
        {
            return _istatisticDAL.Max(predicate, column);       
        }

        public int? Max(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return _istatisticDAL.Max(predicate, column);
        }

        public decimal Min(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal>> column)
        {
            return _istatisticDAL.Min(predicate, column);
        }

        public int? Min(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return _istatisticDAL.Min(predicate, column);
        }

        public decimal Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, decimal?>> column)
        {
            return _istatisticDAL.Sum(predicate, column);
        }

        public int? Sum(Expression<Func<T, bool>> predicate, Expression<Func<T, int?>> column)
        {
            return _istatisticDAL.Sum(predicate, column ) ;
        }
    }
}
