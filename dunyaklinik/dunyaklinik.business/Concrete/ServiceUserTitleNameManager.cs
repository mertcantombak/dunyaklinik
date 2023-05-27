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
    public class ServiceUserTitleNameManager : IServiceUserTitleNameService
    {
        private IServiceUserTitleNameDal _serviceUserTitleNamesDal;
        public ServiceUserTitleNameManager(IServiceUserTitleNameDal serviceUserTitleNamesDal)
        {
            _serviceUserTitleNamesDal = serviceUserTitleNamesDal;
        }

        public void Add(ServiceUserTitleName serviceUserTitleNames)
        {
            _serviceUserTitleNamesDal.Add(serviceUserTitleNames);
        }

        public void Delete(ServiceUserTitleName serviceUserTitleNames)
        {
            _serviceUserTitleNamesDal.Delete(serviceUserTitleNames);
        }

        public List<ServiceUserTitleName> GetList()
        {
            return _serviceUserTitleNamesDal.GetList();
        }

        public void Update(ServiceUserTitleName serviceUserTitleNames)
        {
            _serviceUserTitleNamesDal.Update(serviceUserTitleNames);
        }
    }
}
