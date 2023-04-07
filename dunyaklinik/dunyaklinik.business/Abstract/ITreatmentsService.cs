using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentsService
    {
        List<Treatments> GetList();
        void Add(Treatments treatment );
        void Update(Treatments treatment );
        void Delete(Treatments treatment );
    }
}
