using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceOrganisationDocumentService
    {
        List<ServiceOrganisationDocument> GetList();
        void Add(ServiceOrganisationDocument serviceOrganisationDocuments);
        void Update(ServiceOrganisationDocument serviceOrganisationDocuments);
        void Delete(ServiceOrganisationDocument serviceOrganisationDocuments);
    }
}
