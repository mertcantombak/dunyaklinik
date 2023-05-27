using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentServiceRatingController : ControllerBase
    {
        private ITreatmentServiceRatingService _service;
        public TreatmentServiceRatingController(ITreatmentServiceRatingService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentServiceRatings")]
        public List<TreatmentServiceRating> GetTreatmentServiceRatings()
        {
            var treatmentServiceRatings = _service.GetList();
            return treatmentServiceRatings;
        }
    }
}
