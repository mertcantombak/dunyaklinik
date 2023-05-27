using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class TreatmentDocument : IEntity
    {
        public int Id { get; set; }

        public string DocumentPath { get; set; } = null!;

        public string? DocumentName { get; set; }

        public string? DocumentExplanation { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public int TreatmentId { get; set; }
    }
}
