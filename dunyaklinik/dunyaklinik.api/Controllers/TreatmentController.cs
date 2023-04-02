using Microsoft.AspNetCore.Mvc;
using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private ITreatmentService _service;
        public TreatmentController(ITreatmentService service) 
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatments")]
        public List<Treatment> GetTreatments()
        {
            var treatments = _service.GetList();

            return treatments;
        }
    }
}
