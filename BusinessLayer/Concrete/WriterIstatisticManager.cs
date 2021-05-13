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
    public class WriterIstatisticManager:IstatisticGenericManager<Writer>,IWriterIstatisticService
    {
        IWriterIstatisticDal _writerIstatisticDal;

        public WriterIstatisticManager(IWriterIstatisticDal writerIstatisticDal):base(writerIstatisticDal)
        {
            _writerIstatisticDal = writerIstatisticDal;
        }
        public int WriterNameFind(string Name)
        {
          return _writerIstatisticDal.GetAll(x => x.WriterName.Contains(Name)).Count();
        }

    }
}
