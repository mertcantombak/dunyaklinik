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
    public class TreatmentTypeManager : ITreatmentTypeService
    {
        private ITreatmentTypeDal _treatmentTypeDal;
        public TreatmentTypeManager(ITreatmentTypeDal treatment_TypeDal)
        {
            _treatmentTypeDal = treatment_TypeDal;
        }

        public void Add(TreatmentType treatmentType )
        {
            _treatmentTypeDal.Add(treatmentType);
        }

        public void Delete(TreatmentType treatmentType)
        {
            _treatmentTypeDal.Delete(treatmentType);
        }

        public List<TreatmentType> GetList()
        {
            return _treatmentTypeDal.GetList();
        }

        public void Update(TreatmentType treatmentType)
        {
            _treatmentTypeDal.Update(treatmentType);
        }
    }
}
