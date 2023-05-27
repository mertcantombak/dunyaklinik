using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class ServiceUserManager : IServiceUserService
    {
        private IServiceUserDal _serviceUsersDal;
        public ServiceUserManager(IServiceUserDal serviceUsersDal)
        {
            _serviceUsersDal = serviceUsersDal;
        }

        public void Add(ServiceUser serviceUsers)
        {
            _serviceUsersDal.Add(serviceUsers);
        }

        public void Delete(ServiceUser serviceUsers)
        {
            _serviceUsersDal.Delete(serviceUsers);
        }

        public List<ServiceUser> GetList()
        {
            return _serviceUsersDal.GetList();
        }

        public void Update(ServiceUser serviceUsers)
        {
            _serviceUsersDal.Update(serviceUsers);
        }
    }
}
