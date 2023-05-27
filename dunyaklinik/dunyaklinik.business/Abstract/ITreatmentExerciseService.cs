using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface ITreatmentExerciseService
    {
        List<TreatmentExercise> GetList();
        void Add(TreatmentExercise treatmentExercise);
        void Update(TreatmentExercise treatmentExercise);
        void Delete(TreatmentExercise treatmentExercise);
    }
}
