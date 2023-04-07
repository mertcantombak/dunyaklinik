using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentServiceRatingsService
    {
        List<TreatmentServiceRatings> GetList();
        void Add(TreatmentServiceRatings treatmentServiceRating);
        void Update(TreatmentServiceRatings treatmentServiceRating);
        void Delete(TreatmentServiceRatings treatmentServiceRating);
    }
}
