using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceBranchDocumentsService
    {
        List<ServiceBranchDocuments> GetList();
        void Add(ServiceBranchDocuments serviceBranchDocuments);
        void Update(ServiceBranchDocuments serviceBranchDocuments);
        void Delete(ServiceBranchDocuments serviceBranchDocuments);
    }
}
