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
    public class TreatmentDocumentsManager : ITreatmentDocumentsService
    {
        private ITreatmentDocumentsDal _treatmentDocumentDal;
        public TreatmentDocumentsManager(ITreatmentDocumentsDal treatmentDocumentDal)
        {
            _treatmentDocumentDal = treatmentDocumentDal;
        }

        public void Add(TreatmentDocuments treatmentDocument)
        {
            _treatmentDocumentDal.Add(treatmentDocument);
        }

        public void Delete(TreatmentDocuments treatmentDocument)
        {
            _treatmentDocumentDal.Delete(treatmentDocument);
        }

        public List<TreatmentDocuments> GetList()
        {
            return _treatmentDocumentDal.GetList();
        }

        public void Update(TreatmentDocuments treatmentDocument)
        {
            _treatmentDocumentDal.Update(treatmentDocument);
        }
    }
}
