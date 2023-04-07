using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentTypesController : ControllerBase
    {
        private ITreatmentTypesService _service;        
        public TreatmentTypesController(ITreatmentTypesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetTreatmentTypes")]
        public List<TreatmentTypes> GetTreatmentTypes()
        {
            var treatment_types = _service.GetList();
            return treatment_types;
        }        
    }
}
