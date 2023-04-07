using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentDocumentsController : ControllerBase
    {
        private ITreatmentDocumentsService _service;
        public TreatmentDocumentsController(ITreatmentDocumentsService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentDocuments")]
        public List<TreatmentDocuments> GetTreatmentDocuments()
        {
            var treatmentDocuments = _service.GetList();

            return treatmentDocuments;
        }
    }
}
