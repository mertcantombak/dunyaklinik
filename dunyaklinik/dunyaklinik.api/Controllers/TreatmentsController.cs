using Microsoft.AspNetCore.Mvc;
using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentsController : ControllerBase
    {
        private ITreatmentsService _service;
        public TreatmentsController(ITreatmentsService service) 
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatments")]
        public List<Treatments> GetTreatments()
        {
            var treatments = _service.GetList();

            return treatments;
        }
    }
}
