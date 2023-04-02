using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Treatment_TypeController : ControllerBase
    {
        private ITreatment_TypeService _service;
        
        public Treatment_TypeController(ITreatment_TypeService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetTreatmentTypes")]
        public List<Treatment_Type> GetTreatment_Types()
        {
            var treatment_types = _service.GetList();
            return treatment_types;
        }        
    }
}
