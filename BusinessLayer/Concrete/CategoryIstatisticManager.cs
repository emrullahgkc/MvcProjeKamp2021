using BusinessLayer.Abstract;
using DataAccessLayer.Abstrack;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
   public  class CategoryIstatisticManager:IstatisticGenericManager<Category>,ICategoryIstatisticService
    {
        ICategoryIstatisticDal _categoryIstatisticDal;
       

        public CategoryIstatisticManager(ICategoryIstatisticDal categoryIstatisticDal):base(categoryIstatisticDal)
        {
            this._categoryIstatisticDal = categoryIstatisticDal;
        }

        public int  CategoryTotal()
        {
          return  _categoryIstatisticDal.GetAll().Count();
        }
        public int CategoryActive()
        {
            return _categoryIstatisticDal.GetAll(x=>x.CategoryStatus==true).Count();
        }
        public int CategoryPassive()
        {
            return _categoryIstatisticDal.GetAll(x => x.CategoryStatus == false).Count();
        }
    }
}
