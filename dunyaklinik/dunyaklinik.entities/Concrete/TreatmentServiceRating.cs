using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class TreatmentServiceRating : IEntity 
    {
        public int Id { get; set; }

        public int TreatmentId { get; set; }

        public string? Explanation { get; set; }

        public int Rate { get; set; }

        public int UserId { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public int ServiceUserId { get; set; }
    }
}
