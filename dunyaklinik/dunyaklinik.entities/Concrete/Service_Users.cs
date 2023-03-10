using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class Service_Users
    {
        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public int profession_id { get; set; }
        public int title_id { get; set; }
        public string profile_image_path { get; set; }
        public string description { get; set; }
        public bool is_active { get; set; }
        public bool is_deleted { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
        public int branch_id { get; set; }
    }
}
