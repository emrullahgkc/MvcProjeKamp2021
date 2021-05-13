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
   public  class CategoryStatisticManager:StatisticGenericManager<Category>,ICategoryStatisticService
    {
        ICategoryStatisticDal _categoryStatisticDal;
       

        public CategoryStatisticManager(ICategoryStatisticDal categoryStatisticDal) :base(categoryStatisticDal)
        {
            this._categoryStatisticDal = categoryStatisticDal;
        }

        public int  CategoryTotal()
        {
          return _categoryStatisticDal.GetAll().Count();
        }
        public int CategoryActive()
        {
            return _categoryStatisticDal.GetAll(x=>x.CategoryStatus==true).Count();
        }
        public int CategoryPassive()
        {
            return _categoryStatisticDal.GetAll(x => x.CategoryStatus == false).Count();
        }
    }
}
