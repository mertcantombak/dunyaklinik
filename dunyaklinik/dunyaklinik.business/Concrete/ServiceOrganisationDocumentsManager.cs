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
    public class ServiceOrganisationDocumentsManager : IServiceOrganisationDocumentsService
    {
        private IServiceOrganisationDocumentsDal _serviceOrganisationDocumentsDal;
        public ServiceOrganisationDocumentsManager(IServiceOrganisationDocumentsDal serviceOrganisationDocumentsDal)
        {
            _serviceOrganisationDocumentsDal = serviceOrganisationDocumentsDal;
        }

        public void Add(ServiceOrganisationDocuments serviceOrganisationDocuments)
        {
            _serviceOrganisationDocumentsDal.Add(serviceOrganisationDocuments);
        }

        public void Delete(ServiceOrganisationDocuments serviceOrganisationDocuments)
        {
            _serviceOrganisationDocumentsDal.Delete(serviceOrganisationDocuments);
        }

        public List<ServiceOrganisationDocuments> GetList()
        {
            return _serviceOrganisationDocumentsDal.GetList();
        }

        public void Update(ServiceOrganisationDocuments serviceOrganisationDocuments)
        {
            _serviceOrganisationDocumentsDal.Update(serviceOrganisationDocuments);
        }
    }
}
