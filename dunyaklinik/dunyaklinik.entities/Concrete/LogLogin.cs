using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class LogLogin : IEntity
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public DateTime? LoginTime { get; set; }

        public DateTime? LastSuccessfulLoginTime { get; set; }

        public DateTime? LastFailedLoginTime { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public virtual User User { get; set; } = null!;
    }
}
