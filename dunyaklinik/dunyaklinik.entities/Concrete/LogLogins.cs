using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class LogLogins : IEntity
    {
        [Key]
        public int id { get; set; }
        public int user_id { get; set; }
        public DateTime? login_time { get; set; }
        public DateTime? last_successful_login_time { get; set; }
        public DateTime? last_failed_login_time { get; set; }
        public bool is_deleted { get; set; }
        public DateTime? created_time { get; set; }
        public DateTime? updated_time { get; set; }
    }
}
