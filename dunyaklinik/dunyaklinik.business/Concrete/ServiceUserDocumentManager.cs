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
    public class ServiceUserDocumentManager : IServiceUserDocumentService
    {
        private IServiceUserDocumentDal _serviceUserDocumentsDal;
        public ServiceUserDocumentManager(IServiceUserDocumentDal serviceUserDocumentsDal)
        {
            _serviceUserDocumentsDal = serviceUserDocumentsDal;
        }

        public void Add(ServiceUserDocument serviceUserDocuments)
        {
            _serviceUserDocumentsDal.Add(serviceUserDocuments);
        }

        public void Delete(ServiceUserDocument serviceUserDocuments)
        {
            _serviceUserDocumentsDal.Delete(serviceUserDocuments);
        }

        public List<ServiceUserDocument> GetList()
        {
            return _serviceUserDocumentsDal.GetList();
        }

        public void Update(ServiceUserDocument serviceUserDocuments)
        {
            _serviceUserDocumentsDal.Update(serviceUserDocuments);
        }
    }
}
