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
    public class ServiceOrganisationManager : IServiceOrganisationService
    {
        private IServiceOrganisationDal _serviceOrganisationDal;
        public ServiceOrganisationManager(IServiceOrganisationDal serviceOrganisationDal)
        {
            _serviceOrganisationDal = serviceOrganisationDal;
        }

        public void Add(ServiceOrganisation serviceOrganisation)
        {
            _serviceOrganisationDal.Add(serviceOrganisation);
        }

        public void Delete(ServiceOrganisation serviceOrganisation)
        {
            _serviceOrganisationDal.Delete(serviceOrganisation);
        }

        public List<ServiceOrganisation> GetList()
        {
            return _serviceOrganisationDal.GetList();
        }

        public void Update(ServiceOrganisation serviceOrganisation)
        {
            _serviceOrganisationDal.Update(serviceOrganisation);
        }
    }
}
