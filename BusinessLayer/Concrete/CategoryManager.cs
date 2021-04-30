using DataAccessLayer.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManage
    {
        GenericRepository<Category> repo_cat = new GenericRepository<Category>();
        public List<Category> GetAllBL()
        {
            return repo_cat.List();
        }
        public void CategoryAddBL(Category p)
        {
            if (p.CategoryName == "" || p.CategoryName.Length <=3 || p.CategoryDescription == "" || p.CategoryName.Length >= 51)
            {
               //hata mesaji
            }
            else
            {
                repo_cat.Insert(p);
            }
        }
    }
}
