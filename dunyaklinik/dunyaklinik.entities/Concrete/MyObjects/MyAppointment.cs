using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete.MyObjects
{
    public class MyAppointment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public DateTime AppointmentTime { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsConfirmed { get; set; }
        public int ServiceUserId { get; set; }
        public string? ServiceUserFirstname { get; set; }
        public string? ServiceUserLastname { get; set; }
        public string ProfessionName { get; set; }
        public string TitleName { get; set; }
    }
}
