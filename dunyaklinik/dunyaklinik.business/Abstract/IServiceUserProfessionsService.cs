using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUserProfessionsService
    {
        List<ServiceUserProfessions> GetList();
        void Add(ServiceUserProfessions serviceUserProfessions);
        void Update(ServiceUserProfessions serviceUserProfessions);
        void Delete(ServiceUserProfessions serviceUserProfessions);
    }
}
