using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentDocumentController : ControllerBase
    {
        private ITreatmentDocumentService _service;
        public TreatmentDocumentController(ITreatmentDocumentService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentDocuments")]
        public List<TreatmentDocument> GetTreatmentDocuments()
        {
            var treatmentDocuments = _service.GetList();

            return treatmentDocuments;
        }
    }
}
