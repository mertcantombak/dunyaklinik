using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentClientRatingsService
    {
        List<TreatmentClientRatings> GetList();
        void Add(TreatmentClientRatings treatmentClientRating);
        void Update(TreatmentClientRatings treatmentClientRating);
        void Delete(TreatmentClientRatings treatmentClientRating);
    }
}
