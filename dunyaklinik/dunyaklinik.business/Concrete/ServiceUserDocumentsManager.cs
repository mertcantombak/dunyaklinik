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
    public class ServiceUserDocumentsManager : IServiceUserDocumentsService
    {
        private IServiceUserDocumentsDal _serviceUserDocumentsDal;
        public ServiceUserDocumentsManager(IServiceUserDocumentsDal serviceUserDocumentsDal)
        {
            _serviceUserDocumentsDal = serviceUserDocumentsDal;
        }

        public void Add(ServiceUserDocuments serviceUserDocuments)
        {
            _serviceUserDocumentsDal.Add(serviceUserDocuments);
        }

        public void Delete(ServiceUserDocuments serviceUserDocuments)
        {
            _serviceUserDocumentsDal.Delete(serviceUserDocuments);
        }

        public List<ServiceUserDocuments> GetList()
        {
            return _serviceUserDocumentsDal.GetList();
        }

        public void Update(ServiceUserDocuments serviceUserDocuments)
        {
            _serviceUserDocumentsDal.Update(serviceUserDocuments);
        }
    }
}
