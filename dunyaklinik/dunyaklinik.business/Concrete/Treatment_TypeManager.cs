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
    public class Treatment_TypeManager : ITreatment_TypeService
    {
        private ITreatment_TypeDal _treatment_TypeDal;

        public Treatment_TypeManager(ITreatment_TypeDal treatment_TypeDal)
        {
            _treatment_TypeDal = treatment_TypeDal;
        }

        public void Add(Treatment_Type treatment_Type)
        {
            _treatment_TypeDal.Add(treatment_Type);
        }

        public void Delete(Treatment_Type treatment_Type)
        {
            _treatment_TypeDal.Delete(treatment_Type);
        }

        public List<Treatment_Type> GetList()
        {
            return _treatment_TypeDal.GetList();
        }

        public void Update(Treatment_Type treatment_Type)
        {
            _treatment_TypeDal.Update(treatment_Type);
        }
    }
}
