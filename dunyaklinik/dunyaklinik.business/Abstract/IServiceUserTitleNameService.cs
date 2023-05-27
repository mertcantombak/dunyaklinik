using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUserTitleNameService
    {
        List<ServiceUserTitleName> GetList();
        void Add(ServiceUserTitleName serviceUserTitleNames );
        void Update(ServiceUserTitleName serviceUserTitleNames );
        void Delete(ServiceUserTitleName serviceUserTitleNames );
    }
}
