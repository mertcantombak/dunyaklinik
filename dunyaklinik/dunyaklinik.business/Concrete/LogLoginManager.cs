using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class LogLoginManager : ILogLoginService
    {
        private ILogLoginDal _logLoginDal;

        public LogLoginManager(ILogLoginDal logLoginDal)
        {
            _logLoginDal = logLoginDal;
        }

        public void Add(LogLogin logLogin)
        {
            _logLoginDal.Add(logLogin);
        }

        public void Delete(LogLogin logLogin)
        {
            _logLoginDal.Delete(logLogin);
        }

        public List<LogLogin> GetList()
        {
            return _logLoginDal.GetList();
        }

        public void Update(LogLogin logLogin)
        {
            _logLoginDal.Update(logLogin);
        }
    }
}
