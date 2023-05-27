using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ILogLoginService
    {
        List<LogLogin> GetList();
        void Add(LogLogin logLogin);
        void Update(LogLogin logLogin);
        void Delete(LogLogin logLogin);
    }
}
