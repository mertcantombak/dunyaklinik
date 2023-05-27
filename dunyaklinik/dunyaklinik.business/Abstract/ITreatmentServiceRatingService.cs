using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentServiceRatingService
    {
        List<TreatmentServiceRating> GetList();
        void Add(TreatmentServiceRating treatmentServiceRating);
        void Update(TreatmentServiceRating treatmentServiceRating);
        void Delete(TreatmentServiceRating treatmentServiceRating);
    }
}
