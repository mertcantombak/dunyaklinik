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
    public class ServiceBranchDocumentsManager : IServiceBranchDocumentsService
    {
        private IServiceBranchDocumentsDal _serviceBranchDocumentsDal;
        public ServiceBranchDocumentsManager(IServiceBranchDocumentsDal serviceBranchDocumentsDal)
        {
            _serviceBranchDocumentsDal = serviceBranchDocumentsDal;
        }

        public void Add(ServiceBranchDocuments serviceBranchDocuments)
        {
            _serviceBranchDocumentsDal.Add(serviceBranchDocuments);
        }

        public void Delete(ServiceBranchDocuments serviceBranchDocuments)
        {
            _serviceBranchDocumentsDal.Delete(serviceBranchDocuments);
        }

        public List<ServiceBranchDocuments> GetList()
        {
            return _serviceBranchDocumentsDal.GetList();
        }

        public void Update(ServiceBranchDocuments serviceBranchDocuments)
        {
            _serviceBranchDocumentsDal.Update(serviceBranchDocuments);
        }
    }
}
