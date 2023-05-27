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
    public class TreatmentServiceRatingManager : ITreatmentServiceRatingService
    {
        private ITreatmentServiceRatingDal _treatmentServiceRatingDal;
        public TreatmentServiceRatingManager(ITreatmentServiceRatingDal treatmentServiceRatingDal)
        {
            _treatmentServiceRatingDal = treatmentServiceRatingDal;
        }

        public void Add(TreatmentServiceRating treatmentServiceRating)
        {
            _treatmentServiceRatingDal.Add(treatmentServiceRating);
        }

        public void Delete(TreatmentServiceRating treatmentServiceRating)
        {
            _treatmentServiceRatingDal.Delete(treatmentServiceRating);
        }

        public List<TreatmentServiceRating> GetList()
        {
            return _treatmentServiceRatingDal.GetList();
        }

        public void Update(TreatmentServiceRating treatmentServiceRating)
        {
            _treatmentServiceRatingDal.Update(treatmentServiceRating);  
        }
    }
}
