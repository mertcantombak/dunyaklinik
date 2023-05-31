using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete.MyObjects
{
    public class MyTreatment
    {
        public int Id { get; set; }
        public int TreatmentTypeId { get; set; }
        public int ServiceUserId { get; set; }
        public string? ServiceUserFirstname { get; set; }
        public string? ServiceUserLastname { get; set; }
        public string TreaatmentTypeName { get; set; }
        public string ProfessionName { get; set; }
        public string ProfessionDescription { get; set; }
        public string TitleName { get; set; }
        public int UserId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? Explanation { get; set; }
        public bool IsFinished { get; set; }
        public bool IsTransferred { get; set; }
        public bool IsDeleted { get; set; }

    }
}
