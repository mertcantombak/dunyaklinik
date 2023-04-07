using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUsersService
    {
        List<ServiceUsers> GetList();
        void Add(ServiceUsers serviceUsers);
        void Update(ServiceUsers serviceUsers);
        void Delete(ServiceUsers serviceUsers);
    }
}
