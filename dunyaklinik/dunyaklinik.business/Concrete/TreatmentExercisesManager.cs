using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class TreatmentExercisesManager : ITreatmentExercisesService
    {
        private ITreatmentExercisesDal _treatmentExerciseDal;
        public TreatmentExercisesManager(ITreatmentExercisesDal treatmentExerciseDal)
        {
            _treatmentExerciseDal = treatmentExerciseDal;
        }

        public void Add(TreatmentExercises treatmentExercise)
        {
            _treatmentExerciseDal.Add(treatmentExercise);
        }

        public void Delete(TreatmentExercises treatmentExercise)
        {
            _treatmentExerciseDal.Delete(treatmentExercise);
        }

        public List<TreatmentExercises> GetList()
        {
            return _treatmentExerciseDal.GetList();
        }

        public void Update(TreatmentExercises treatmentExercise)
        {
            _treatmentExerciseDal.Update(treatmentExercise);
        }
    }
}
