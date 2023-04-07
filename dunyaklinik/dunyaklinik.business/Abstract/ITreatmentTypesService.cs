using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentTypesService
    {
        List<TreatmentTypes> GetList();
        void Add(TreatmentTypes treatmentType);
        void Update(TreatmentTypes treatmentType);
        void Delete(TreatmentTypes treatmentType);
    }
}
