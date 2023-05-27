using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class ServiceUserProfession : IEntity
    {
        public int Id { get; set; }

        public string ProfessionName { get; set; } = null!;

        public string? Description { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public bool IsActive { get; set; }
    }
}
