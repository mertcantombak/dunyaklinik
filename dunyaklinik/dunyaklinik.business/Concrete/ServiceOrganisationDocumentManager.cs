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
    public class ServiceOrganisationDocumentManager : IServiceOrganisationDocumentService
    {
        private IServiceOrganisationDocumentDal _serviceOrganisationDocumentsDal;
        public ServiceOrganisationDocumentManager(IServiceOrganisationDocumentDal serviceOrganisationDocumentsDal)
        {
            _serviceOrganisationDocumentsDal = serviceOrganisationDocumentsDal;
        }

        public void Add(ServiceOrganisationDocument serviceOrganisationDocuments)
        {
            _serviceOrganisationDocumentsDal.Add(serviceOrganisationDocuments);
        }

        public void Delete(ServiceOrganisationDocument serviceOrganisationDocuments)
        {
            _serviceOrganisationDocumentsDal.Delete(serviceOrganisationDocuments);
        }

        public List<ServiceOrganisationDocument> GetList()
        {
            return _serviceOrganisationDocumentsDal.GetList();
        }

        public void Update(ServiceOrganisationDocument serviceOrganisationDocuments)
        {
            _serviceOrganisationDocumentsDal.Update(serviceOrganisationDocuments);
        }
    }
}
