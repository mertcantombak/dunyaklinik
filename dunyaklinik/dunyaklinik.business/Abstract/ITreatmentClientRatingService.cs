using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentClientRatingService
    {
        List<TreatmentClientRating> GetList();
        void Add(TreatmentClientRating treatmentClientRating);
        void Update(TreatmentClientRating treatmentClientRating);
        void Delete(TreatmentClientRating treatmentClientRating);
    }
}
