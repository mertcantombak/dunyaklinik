using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceBranchDocumentService
    {
        List<ServiceBranchDocument> GetList();
        void Add(ServiceBranchDocument serviceBranchDocuments);
        void Update(ServiceBranchDocument serviceBranchDocuments);
        void Delete(ServiceBranchDocument serviceBranchDocuments);
    }
}
