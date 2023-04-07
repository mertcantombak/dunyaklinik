using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUserTitleNamesService
    {
        List<ServiceUserTitleNames> GetList();
        void Add(ServiceUserTitleNames serviceUserTitleNames );
        void Update(ServiceUserTitleNames serviceUserTitleNames );
        void Delete(ServiceUserTitleNames serviceUserTitleNames );
    }
}
