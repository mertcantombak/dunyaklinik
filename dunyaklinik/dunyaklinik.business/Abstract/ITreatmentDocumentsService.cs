using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentDocumentsService
    {
        List<TreatmentDocuments> GetList();
        void Add(TreatmentDocuments treatmentDocument);
        void Update(TreatmentDocuments treatmentDocument);
        void Delete(TreatmentDocuments treatmentDocument);
    }
}
