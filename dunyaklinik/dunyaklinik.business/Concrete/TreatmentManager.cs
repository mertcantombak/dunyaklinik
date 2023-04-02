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
    public class TreatmentManager : ITreatmentService
    {
        private ITreatmentDal _treatmentDal;
        public TreatmentManager(ITreatmentDal treatmentDal) 
        { 
            _treatmentDal= treatmentDal;
        }   
        public void Add(Treatment treatment)
        {
            _treatmentDal.Add(treatment)
        }

        public void Delete(Treatment treatment)
        {
            _treatmentDal.Delete(treatment);
        }

        public List<Treatment> GetList()
        {
            return _treatmentDal.GetList();
        }

        public void Update(Treatment treatment)
        {
            _treatmentDal.Update(treatment);
        }
    }
}
