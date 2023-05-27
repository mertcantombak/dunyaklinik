using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentTypeController : ControllerBase
    {
        private ITreatmentTypeService _service;        
        public TreatmentTypeController(ITreatmentTypeService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetTreatmentTypes")]
        public List<TreatmentType> GetTreatmentTypes()
        {
            var treatment_types = _service.GetList();
            return treatment_types;
        }        
    }
}
