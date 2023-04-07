using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentExercisesController : ControllerBase
    {
        private ITreatmentExercisesService _service;
        public TreatmentExercisesController(ITreatmentExercisesService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentExercises")]
        public List<TreatmentExercises> GetTreatmentExercises()
        {
            var treatmentExercises = _service.GetList();

            return treatmentExercises;
        }
    }
}
