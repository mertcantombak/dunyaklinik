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
    public class LogLoginsManager : ILogLoginsService
    {
        private ILogLoginsDal _logLoginDal;

        public LogLoginsManager(ILogLoginsDal logLoginDal)
        {
            _logLoginDal = logLoginDal;
        }

        public void Add(LogLogins logLogin)
        {
            _logLoginDal.Add(logLogin);
        }

        public void Delete(LogLogins logLogin)
        {
            _logLoginDal.Delete(logLogin);
        }

        public List<LogLogins> GetList()
        {
            return _logLoginDal.GetList();
        }

        public void Update(LogLogins logLogin)
        {
            _logLoginDal.Update(logLogin);
        }
    }
}
