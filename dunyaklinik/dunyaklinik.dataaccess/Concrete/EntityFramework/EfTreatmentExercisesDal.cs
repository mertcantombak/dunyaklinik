﻿using dunyaklinik.core.DataAccess.EntityFramework;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.dataaccess.Concrete.EntityFramework
{
    public class EfTreatmentExercisesDal : EfEntityRepositoryBase<TreatmentExercises, DunyaKlinikContext>, ITreatmentExercisesDal
    {
    }
}
