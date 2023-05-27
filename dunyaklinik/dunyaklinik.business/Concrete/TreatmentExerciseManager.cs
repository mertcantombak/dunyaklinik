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
    public class TreatmentExerciseManager : ITreatmentExerciseService
    {
        private ITreatmentExerciseDal _treatmentExerciseDal;
        public TreatmentExerciseManager(ITreatmentExerciseDal treatmentExerciseDal)
        {
            _treatmentExerciseDal = treatmentExerciseDal;
        }

        public void Add(TreatmentExercise treatmentExercise)
        {
            _treatmentExerciseDal.Add(treatmentExercise);
        }

        public void Delete(TreatmentExercise treatmentExercise)
        {
            _treatmentExerciseDal.Delete(treatmentExercise);
        }

        public List<TreatmentExercise> GetList()
        {
            return _treatmentExerciseDal.GetList();
        }

        public void Update(TreatmentExercise treatmentExercise)
        {
            _treatmentExerciseDal.Update(treatmentExercise);
        }
    }
}
