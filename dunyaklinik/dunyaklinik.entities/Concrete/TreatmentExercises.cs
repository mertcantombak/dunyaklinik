using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class TreatmentExercises : IEntity
    {
        [Key]
        public int id { get; set; }
        public int treatment_id { get; set; }
        public string exercise_file_path { get; set; }
        public string exercise_name { get; set; }
        public string exercise_explanation { get; set; }
        public bool is_deleted { get; set; }
        public DateTime? created_time { get; set; }
        public DateTime? updated_time { get; set; }
    }
}
