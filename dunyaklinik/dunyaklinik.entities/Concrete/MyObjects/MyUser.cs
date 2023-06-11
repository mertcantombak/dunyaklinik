using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete.MyObjects
{
    public class MyUser
    {
        public int UserId { get; set; }

        public string? MailAddress { get; set; }

        public int UserType { get; set; }

        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Nationality { get; set; }

        public string? IdentityCardNo { get; set; }

        public string? Gender { get; set; }

        public DateTime? BirthDate { get; set; }
        public string? BirthDateStr { get; set; }

        public string? Phone { get; set; }

        public string? PhoneCode { get; set; }

        public string? ProfileImagePath { get; set; }
    }
}
