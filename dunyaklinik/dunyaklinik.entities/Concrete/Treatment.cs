using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class Treatment : IEntity
    {
        [Key]
        public int id { get; set; }
        public int treatment_type_id { get; set; }
        public int service_user_id { get; set; }
        public int client_user_id { get; set; }
        public DateTime start_time { get; set; }
        public DateTime end_time { get; set; }
        public string explanation { get; set; }
        public bool is_finished { get; set; }
        public bool is_transferred { get; set; }
        public bool is_deleted { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
    }
}
