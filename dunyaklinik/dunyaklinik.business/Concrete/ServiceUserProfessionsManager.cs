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
    public class ServiceUserProfessionsManager : IServiceUserProfessionsService
    {
        private IServiceUserProfessionsDal _serviceUserProfessionsDal;
        public ServiceUserProfessionsManager(IServiceUserProfessionsDal serviceUserProfessionsDal)
        {
            _serviceUserProfessionsDal = serviceUserProfessionsDal;
        }

        public void Add(ServiceUserProfessions serviceUserProfessions)
        {
            _serviceUserProfessionsDal.Add(serviceUserProfessions);
        }

        public void Delete(ServiceUserProfessions serviceUserProfessions)
        {
            _serviceUserProfessionsDal.Delete(serviceUserProfessions);
        }

        public List<ServiceUserProfessions> GetList()
        {
            return _serviceUserProfessionsDal.GetList();
        }

        public void Update(ServiceUserProfessions serviceUserProfessions)
        {
            _serviceUserProfessionsDal.Update(serviceUserProfessions);
        }
    }
}
