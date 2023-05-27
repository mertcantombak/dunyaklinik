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
    public class TreatmentClientRatingManager : ITreatmentClientRatingService
    {
        private ITreatmentClientRatingDal _treatmentClientRatingDal;
        public TreatmentClientRatingManager(ITreatmentClientRatingDal treatmentClientRatingDal)
        {
            _treatmentClientRatingDal = treatmentClientRatingDal;
        }

        public void Add(TreatmentClientRating treatmentClientRating)
        {
            _treatmentClientRatingDal.Add(treatmentClientRating);   
        }

        public void Delete(TreatmentClientRating treatmentClientRating)
        {
            _treatmentClientRatingDal.Delete(treatmentClientRating);
        }

        public List<TreatmentClientRating> GetList()
        {
            return _treatmentClientRatingDal.GetList();
        }

        public void Update(TreatmentClientRating treatmentClientRating)
        {
            _treatmentClientRatingDal.Update(treatmentClientRating);
        }
    }
}
