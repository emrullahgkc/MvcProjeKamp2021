﻿using DataAccessLayer.Abstrack;
using DataAccessLayer.Concrete.Repositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
   public class EfCategoryIstatisticDal:IstatisticRepository<Category> ,ICategoryIstatisticDal
    {
       
    }
}
