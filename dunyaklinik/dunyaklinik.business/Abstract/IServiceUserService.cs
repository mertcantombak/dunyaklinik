using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUserService
    {
        List<ServiceUser> GetList();
        void Add(ServiceUser serviceUsers);
        void Update(ServiceUser serviceUsers);
        void Delete(ServiceUser serviceUsers);
    }
}
