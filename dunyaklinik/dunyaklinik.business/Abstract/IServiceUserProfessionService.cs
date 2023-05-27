using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUserProfessionService
    {
        List<ServiceUserProfession> GetList();
        void Add(ServiceUserProfession serviceUserProfessions);
        void Update(ServiceUserProfession serviceUserProfessions);
        void Delete(ServiceUserProfession serviceUserProfessions);
    }
}
