using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentServiceRatingsController : ControllerBase
    {
        private ITreatmentServiceRatingsService _service;
        public TreatmentServiceRatingsController(ITreatmentServiceRatingsService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentServiceRatings")]
        public List<TreatmentServiceRatings> GetTreatmentServiceRatings()
        {
            var treatmentServiceRatings = _service.GetList();
            return treatmentServiceRatings;
        }
    }
}
