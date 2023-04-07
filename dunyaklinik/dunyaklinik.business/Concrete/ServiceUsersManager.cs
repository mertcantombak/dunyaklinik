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
    public class ServiceUsersManager : IServiceUsersService
    {
        private IServiceUsersDal _serviceUsersDal;
        public ServiceUsersManager(IServiceUsersDal serviceUsersDal)
        {
            _serviceUsersDal = serviceUsersDal;
        }

        public void Add(ServiceUsers serviceUsers)
        {
            _serviceUsersDal.Add(serviceUsers);
        }

        public void Delete(ServiceUsers serviceUsers)
        {
            _serviceUsersDal.Delete(serviceUsers);
        }

        public List<ServiceUsers> GetList()
        {
            return _serviceUsersDal.GetList();
        }

        public void Update(ServiceUsers serviceUsers)
        {
            _serviceUsersDal.Update(serviceUsers);
        }
    }
}
