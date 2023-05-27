using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentExerciseController : ControllerBase
    {
        private ITreatmentExerciseService _service;
        public TreatmentExerciseController(ITreatmentExerciseService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatmentExercises")]
        public List<TreatmentExercise> GetTreatmentExercises()
        {
            var treatmentExercises = _service.GetList();

            return treatmentExercises;
        }
    }
}
