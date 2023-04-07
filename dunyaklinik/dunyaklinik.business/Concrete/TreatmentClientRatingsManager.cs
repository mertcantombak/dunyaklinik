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
    public class TreatmentClientRatingsManager : ITreatmentClientRatingsService
    {
        private ITreatmentClientRatingsDal _treatmentClientRatingDal;
        public TreatmentClientRatingsManager(ITreatmentClientRatingsDal treatmentClientRatingDal)
        {
            _treatmentClientRatingDal = treatmentClientRatingDal;
        }

        public void Add(TreatmentClientRatings treatmentClientRating)
        {
            _treatmentClientRatingDal.Add(treatmentClientRating);   
        }

        public void Delete(TreatmentClientRatings treatmentClientRating)
        {
            _treatmentClientRatingDal.Delete(treatmentClientRating);
        }

        public List<TreatmentClientRatings> GetList()
        {
            return _treatmentClientRatingDal.GetList();
        }

        public void Update(TreatmentClientRatings treatmentClientRating)
        {
            _treatmentClientRatingDal.Update(treatmentClientRating);
        }
    }
}
