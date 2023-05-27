using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class ServiceOrganisation : IEntity
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string? Phone { get; set; }

        public string? PhoneCode { get; set; }

        public string? Address { get; set; }

        public string? MailAddress { get; set; }

        public string? Description { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public string? Fax { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public virtual ICollection<ServiceBranchGeneral> ServiceBranchGenerals { get; } = new List<ServiceBranchGeneral>();

        public virtual ICollection<ServiceOrganisationDocument> ServiceOrganisationDocuments { get; } = new List<ServiceOrganisationDocument>();
    }
}
