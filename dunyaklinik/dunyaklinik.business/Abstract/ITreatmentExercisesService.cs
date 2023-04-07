using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentExercisesService
    {
        List<TreatmentExercises> GetList();
        void Add(TreatmentExercises treatmentExercise);
        void Update(TreatmentExercises treatmentExercise);
        void Delete(TreatmentExercises treatmentExercise);
    }
}
