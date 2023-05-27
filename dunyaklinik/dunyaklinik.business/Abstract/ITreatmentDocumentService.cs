using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentDocumentService
    {
        List<TreatmentDocument> GetList();
        void Add(TreatmentDocument treatmentDocument);
        void Update(TreatmentDocument treatmentDocument);
        void Delete(TreatmentDocument treatmentDocument);
    }
}
