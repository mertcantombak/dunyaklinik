using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class TreatmentExercise : IEntity
    {
        public int Id { get; set; }

        public int TreatmentId { get; set; }

        public string ExerciseFilePath { get; set; } = null!;

        public string? ExerciseName { get; set; }

        public string? ExerciseExplanation { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }
    }
}
