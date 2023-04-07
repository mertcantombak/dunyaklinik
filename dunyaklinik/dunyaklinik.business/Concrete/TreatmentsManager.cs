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
    public class TreatmentsManager : ITreatmentsService
    {
        private ITreatmentsDal _treatmentDal;
        public TreatmentsManager(ITreatmentsDal treatmentDal) 
        { 
            _treatmentDal= treatmentDal;
        }   
        public void Add(Treatments treatment)
        {
            _treatmentDal.Add(treatment);
        }

        public void Delete(Treatments treatment)
        {
            _treatmentDal.Delete(treatment);
        }

        public List<Treatments> GetList()
        {
            return _treatmentDal.GetList();
        }

        public void Update(Treatments treatment)
        {
            _treatmentDal.Update(treatment);
        }
    }
}
