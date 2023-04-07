using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ILogLoginsService
    {
        List<LogLogins> GetList();
        void Add(LogLogins logLogin);
        void Update(LogLogins logLogin);
        void Delete(LogLogins logLogin);
    }
}
