using dunyaklinik.core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class User : IEntity
    {
        public int UserId { get; set; }

        public string? Password { get; set; }

        public string? MailAddress { get; set; }

        public int UserType { get; set; }

        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Nationality { get; set; }

        public string? IdentityCardNo { get; set; }

        public string? Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public string? Phone { get; set; }

        public string? PhoneCode { get; set; }

        public bool? IsActive { get; set; }

        public bool? IsPhoneVerified { get; set; }

        public bool? IsMailVerified { get; set; }

        public DateTime? CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public string? ProfileImagePath { get; set; }

        public virtual ICollection<LogLogin> LogLogins { get; } = new List<LogLogin>();

    }
}
