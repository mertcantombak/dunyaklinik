using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentClientRatingsController : ControllerBase
    {
        private ITreatmentClientRatingsService _service;
        public TreatmentClientRatingsController(ITreatmentClientRatingsService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentClientRatings")]
        public List<TreatmentClientRatings> GetTreatmentClientRatings()
        {
            var treatmentClientRatings = _service.GetList();

            return treatmentClientRatings;
        }
    }
}
