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
    public class ServiceUserProfessionManager : IServiceUserProfessionService
    {
        private IServiceUserProfessionDal _serviceUserProfessionsDal;
        public ServiceUserProfessionManager(IServiceUserProfessionDal serviceUserProfessionsDal)
        {
            _serviceUserProfessionsDal = serviceUserProfessionsDal;
        }

        public void Add(ServiceUserProfession serviceUserProfessions)
        {
            _serviceUserProfessionsDal.Add(serviceUserProfessions);
        }

        public void Delete(ServiceUserProfession serviceUserProfessions)
        {
            _serviceUserProfessionsDal.Delete(serviceUserProfessions);
        }

        public List<ServiceUserProfession> GetList()
        {
            return _serviceUserProfessionsDal.GetList(q => q.IsActive);
        }

        public void Update(ServiceUserProfession serviceUserProfessions)
        {
            _serviceUserProfessionsDal.Update(serviceUserProfessions);
        }
    }
}
