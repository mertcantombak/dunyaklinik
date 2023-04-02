using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatment_TypeService
    {
        List<Treatment_Type> GetList();
        void Add(Treatment_Type treatment_Type);
        void Update(Treatment_Type treatment_Type);
        void Delete(Treatment_Type treatment_Type);
    }
}
