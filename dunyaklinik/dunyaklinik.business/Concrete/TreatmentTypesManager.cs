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
    public class TreatmentTypesManager : ITreatmentTypesService
    {
        private ITreatmentTypesDal _treatmentTypeDal;
        public TreatmentTypesManager(ITreatmentTypesDal treatment_TypeDal)
        {
            _treatmentTypeDal = treatment_TypeDal;
        }

        public void Add(TreatmentTypes treatmentType )
        {
            _treatmentTypeDal.Add(treatmentType);
        }

        public void Delete(TreatmentTypes treatmentType)
        {
            _treatmentTypeDal.Delete(treatmentType);
        }

        public List<TreatmentTypes> GetList()
        {
            return _treatmentTypeDal.GetList();
        }

        public void Update(TreatmentTypes treatmentType)
        {
            _treatmentTypeDal.Update(treatmentType);
        }
    }
}
