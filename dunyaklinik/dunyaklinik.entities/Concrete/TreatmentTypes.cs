using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class TreatmentTypes : IEntity
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public bool is_deleted { get; set; }
        public DateTime? created_time { get; set; }
        public DateTime? updated_time { get; set; }
    }
}
