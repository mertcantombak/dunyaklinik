using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentService
    {
        List<Treatment> GetList();
        void Add(Treatment nesne);
        void Update(Treatment nesne);
        void Delete(Treatment nesne);
    }
}
