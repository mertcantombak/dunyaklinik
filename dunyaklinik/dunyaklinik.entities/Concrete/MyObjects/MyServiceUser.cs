using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete.MyObjects
{
    public class MyServiceUser
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }
        public string? Gender { get; set; }
        public string? Phone { get; set; }

        public string? PhoneCode { get; set; }
        public string? MailAddress { get; set; }

        public int? ProfessionId { get; set; }
        public string ProfessionName { get; set; }
        public string? ProfessionDescription { get; set; }

        public int? TitleId { get; set; }
        public string TitleName { get; set; }
        public int? BranchId { get; set; }
        public string? ProfileImagePath { get; set; }
        public string? Description { get; set; }
    }
}
