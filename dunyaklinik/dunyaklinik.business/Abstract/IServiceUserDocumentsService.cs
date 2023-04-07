using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceUserDocumentsService
    {
        List<ServiceUserDocuments> GetList();
        void Add(ServiceUserDocuments serviceUserDocuments);
        void Update(ServiceUserDocuments serviceUserDocuments);
        void Delete(ServiceUserDocuments serviceUserDocuments);
    }
}
