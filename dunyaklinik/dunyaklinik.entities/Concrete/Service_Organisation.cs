using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class Service_Organisation
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
        public string phone_code { get; set; }
        public string address { get; set; }
        public string mail_address { get; set; }
        public string description { get; set; }
        public bool is_active { get; set; }
        public bool is_deleted { get; set; }
        public string fax { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
    }
}
