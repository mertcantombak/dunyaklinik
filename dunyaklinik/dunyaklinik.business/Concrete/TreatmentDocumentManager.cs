using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class TreatmentDocumentManager : ITreatmentDocumentService
    {
        private ITreatmentDocumentDal _treatmentDocumentDal;
        public TreatmentDocumentManager(ITreatmentDocumentDal treatmentDocumentDal)
        {
            _treatmentDocumentDal = treatmentDocumentDal;
        }

        public void Add(TreatmentDocument treatmentDocument)
        {
            _treatmentDocumentDal.Add(treatmentDocument);
        }

        public void Delete(TreatmentDocument treatmentDocument)
        {
            _treatmentDocumentDal.Delete(treatmentDocument);
        }

        public List<TreatmentDocument> GetList()
        {
            return _treatmentDocumentDal.GetList();
        }

        public void Update(TreatmentDocument treatmentDocument)
        {
            _treatmentDocumentDal.Update(treatmentDocument);
        }
    }
}
