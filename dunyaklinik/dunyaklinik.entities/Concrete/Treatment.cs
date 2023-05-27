using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class Treatment : IEntity
    {
        public int Id { get; set; }

        public int TreatmentTypeId { get; set; }

        public int ServiceUserId { get; set; }

        public int UserId { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime? EndTime { get; set; }

        public string? Explanation { get; set; }

        public bool IsFinished { get; set; }

        public bool IsTransferred { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public virtual User User { get; set; } = null!;

        public virtual ServiceUser ServiceUser { get; set; } = null!;

        public virtual ICollection<TreatmentClientRating> TreatmentClientRatings { get; } = new List<TreatmentClientRating>();

        public virtual ICollection<TreatmentDocument> TreatmentDocuments { get; } = new List<TreatmentDocument>();

        public virtual ICollection<TreatmentExercise> TreatmentExercises { get; } = new List<TreatmentExercise>();

        public virtual ICollection<TreatmentServiceRating> TreatmentServiceRatings { get; } = new List<TreatmentServiceRating>();

        public virtual TreatmentType TreatmentType { get; set; } = null!;
    }
}
