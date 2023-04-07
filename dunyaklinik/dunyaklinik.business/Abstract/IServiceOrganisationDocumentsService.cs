using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceOrganisationDocumentsService
    {
        List<ServiceOrganisationDocuments> GetList();
        void Add(ServiceOrganisationDocuments serviceOrganisationDocuments);
        void Update(ServiceOrganisationDocuments serviceOrganisationDocuments);
        void Delete(ServiceOrganisationDocuments serviceOrganisationDocuments);
    }
}
