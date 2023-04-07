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
    public class TreatmentServiceRatingsManager : ITreatmentServiceRatingsService
    {
        private ITreatmentServiceRatingsDal _treatmentServiceRatingDal;
        public TreatmentServiceRatingsManager(ITreatmentServiceRatingsDal treatmentServiceRatingDal)
        {
            _treatmentServiceRatingDal = treatmentServiceRatingDal;
        }

        public void Add(TreatmentServiceRatings treatmentServiceRating)
        {
            _treatmentServiceRatingDal.Add(treatmentServiceRating);
        }

        public void Delete(TreatmentServiceRatings treatmentServiceRating)
        {
            _treatmentServiceRatingDal.Delete(treatmentServiceRating);
        }

        public List<TreatmentServiceRatings> GetList()
        {
            return _treatmentServiceRatingDal.GetList();
        }

        public void Update(TreatmentServiceRatings treatmentServiceRating)
        {
            _treatmentServiceRatingDal.Update(treatmentServiceRating);  
        }
    }
}
