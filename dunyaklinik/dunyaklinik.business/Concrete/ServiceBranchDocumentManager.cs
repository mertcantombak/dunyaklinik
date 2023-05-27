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
    public class ServiceBranchDocumentManager : IServiceBranchDocumentService
    {
        private IServiceBranchDocumentDal _serviceBranchDocumentsDal;
        public ServiceBranchDocumentManager(IServiceBranchDocumentDal serviceBranchDocumentsDal)
        {
            _serviceBranchDocumentsDal = serviceBranchDocumentsDal;
        }

        public void Add(ServiceBranchDocument serviceBranchDocuments)
        {
            _serviceBranchDocumentsDal.Add(serviceBranchDocuments);
        }

        public void Delete(ServiceBranchDocument serviceBranchDocuments)
        {
            _serviceBranchDocumentsDal.Delete(serviceBranchDocuments);
        }

        public List<ServiceBranchDocument> GetList()
        {
            return _serviceBranchDocumentsDal.GetList();
        }

        public void Update(ServiceBranchDocument serviceBranchDocuments)
        {
            _serviceBranchDocumentsDal.Update(serviceBranchDocuments);
        }
    }
}
