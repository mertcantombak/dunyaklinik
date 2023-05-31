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
    public class ServiceUser : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public int? ProfessionId { get; set; }

        public int? TitleId { get; set; }

        public string? ProfileImagePath { get; set; }

        public string? Description { get; set; }
        public string? Address { get; set; }
        public bool? IsActive { get; set; }
        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public int? BranchId { get; set; }

        public virtual ServiceBranchGeneral? Branch { get; set; }

        public virtual ServiceUserProfession? Profession { get; set; }

        public virtual ICollection<ServiceUserDocument> ServiceUserDocuments { get; } = new List<ServiceUserDocument>();

        public virtual ServiceUserTitleName? Title { get; set; }

        public virtual ICollection<TreatmentClientRating> TreatmentClientRatings { get; } = new List<TreatmentClientRating>();

        public virtual ICollection<TreatmentServiceRating> TreatmentServiceRatings { get; } = new List<TreatmentServiceRating>();

        public virtual User User { get; set; } = null!;
    }
}
