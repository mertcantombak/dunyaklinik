﻿using dunyaklinik.business.Abstract;
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
        public List<TreatmentExercise> GetTreatmentExercises(int? TreatmentId, bool? IsDeleted)
        {
            var treatmentExercises = new List<TreatmentExercise>();
            if(TreatmentId != null && IsDeleted != null)
            {
                treatmentExercises = _service.GetList(q => q.TreatmentId == TreatmentId && q.IsDeleted == IsDeleted);
            }
            else if(TreatmentId != null)
            {
                treatmentExercises = _service.GetList(q => q.TreatmentId == TreatmentId);
            }
            else
            {
                treatmentExercises = _service.GetList();
            }

            return treatmentExercises;
        }
    }
}
