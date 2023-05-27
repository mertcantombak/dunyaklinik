using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentClientRatingController : ControllerBase
    {
        private ITreatmentClientRatingService _service;
        public TreatmentClientRatingController(ITreatmentClientRatingService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentClientRatings")]
        public List<TreatmentClientRating> GetTreatmentClientRatings()
        {
            var treatmentClientRatings = _service.GetList();

            return treatmentClientRatings;
        }
    }
}
