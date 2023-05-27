using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUserDocumentService
    {
        List<ServiceUserDocument> GetList();
        void Add(ServiceUserDocument serviceUserDocuments);
        void Update(ServiceUserDocument serviceUserDocuments);
        void Delete(ServiceUserDocument serviceUserDocuments);
    }
}
