using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceOrganisationService
    {
        List<ServiceOrganisation> GetList();
        void Add(ServiceOrganisation serviceOrganisation);
        void Update(ServiceOrganisation serviceOrganisation);
        void Delete(ServiceOrganisation serviceOrganisation);
    }
}
