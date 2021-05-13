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
    public class HeadingIstatisticManager: IstatisticGenericManager<Heading>, IHeadingIstatisticService
    {
        IHeadingIstatisticDal _headingIstatisticDal;

        public HeadingIstatisticManager(IHeadingIstatisticDal headingIstatisticDal):base(headingIstatisticDal)
        {
            _headingIstatisticDal = headingIstatisticDal;
        }

        public int HeadingCategoryName(string Name)
        {
            return _headingIstatisticDal.GetAll(x => x.Category.CategoryName == Name).Count();
        }     
        public int HeadingCategoryId(Category category)
        {
            return _headingIstatisticDal.GetAll(x => x.Category.CategoryID == category.CategoryID).Count();
        }
        public int HeadingCategoryId(int id)
        {
            return _headingIstatisticDal.GetAll(x => x.Category.CategoryID == id).Count();
        }
        public string HeadingMaxCategoryTOP()
        {
            return  _headingIstatisticDal.GetAll().GroupBy(x => x.Category.CategoryName).OrderByDescending(x => x.Count()).Select(y => y.Key).FirstOrDefault();
          
        }
    }
}
