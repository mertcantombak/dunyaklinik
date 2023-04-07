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
    public class ServiceUserTitleNamesManager : IServiceUserTitleNamesService
    {
        private IServiceUserTitleNamesDal _serviceUserTitleNamesDal;
        public ServiceUserTitleNamesManager(IServiceUserTitleNamesDal serviceUserTitleNamesDal)
        {
            _serviceUserTitleNamesDal = serviceUserTitleNamesDal;
        }

        public void Add(ServiceUserTitleNames serviceUserTitleNames)
        {
            _serviceUserTitleNamesDal.Add(serviceUserTitleNames);
        }

        public void Delete(ServiceUserTitleNames serviceUserTitleNames)
        {
            _serviceUserTitleNamesDal.Delete(serviceUserTitleNames);
        }

        public List<ServiceUserTitleNames> GetList()
        {
            return _serviceUserTitleNamesDal.GetList();
        }

        public void Update(ServiceUserTitleNames serviceUserTitleNames)
        {
            _serviceUserTitleNamesDal.Update(serviceUserTitleNames);
        }
    }
}
