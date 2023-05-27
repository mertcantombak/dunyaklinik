using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class ServiceBranchDocument : IEntity
    {
        public int Id { get; set; }

        public int BranchId { get; set; }

        public string DocumentPath { get; set; } = null!;

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public virtual ServiceBranchGeneral Branch { get; set; } = null!;
    }
}
