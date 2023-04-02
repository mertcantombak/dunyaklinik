using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentTypeService
    {
        List<TreatmentType> GetList();
        void Add(TreatmentType treatmentType);
        void Update(TreatmentType treatmentType);
        void Delete(TreatmentType treatmentType);
    }
}
