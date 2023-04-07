using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IServiceBranchGeneralService
    {
        List<ServiceBranchGeneral> GetList();
        void Add(ServiceBranchGeneral serviceBranchGeneral);
        void Update(ServiceBranchGeneral serviceBranchGeneral);
        void Delete(ServiceBranchGeneral serviceBranchGeneral);
    }
}
