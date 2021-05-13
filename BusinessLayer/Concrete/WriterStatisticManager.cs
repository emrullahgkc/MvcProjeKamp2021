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
    public class WriterStatisticManager:StatisticGenericManager<Writer>,IWriterStatisticService
    {
        IWriterStatisticDal _writerIstatisticDal;

        public WriterStatisticManager(IWriterStatisticDal writerStatisticDal):base(writerStatisticDal)
        {
            _writerIstatisticDal = writerStatisticDal;
        }
        public int WriterNameFind(string Name)
        {
          return _writerIstatisticDal.GetAll(x => x.WriterName.Contains(Name)).Count();
        }

    }
}
