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
    public class ServiceBranchGeneralManager : IServiceBranchGeneralService
    {
        private IServiceBranchGeneralDal _serviceBranchGeneralDal;
        public ServiceBranchGeneralManager(IServiceBranchGeneralDal serviceBranchGeneralDal)
        {
            _serviceBranchGeneralDal = serviceBranchGeneralDal;
        }

        public void Add(ServiceBranchGeneral serviceBranchGeneral)
        {
            _serviceBranchGeneralDal.Add(serviceBranchGeneral);
        }

        public void Delete(ServiceBranchGeneral serviceBranchGeneral)
        {
            _serviceBranchGeneralDal.Delete(serviceBranchGeneral);
        }

        public List<ServiceBranchGeneral> GetList()
        {
           return _serviceBranchGeneralDal.GetList();
        }

        public void Update(ServiceBranchGeneral serviceBranchGeneral)
        {
            _serviceBranchGeneralDal.Update(serviceBranchGeneral);
        }
    }
}
