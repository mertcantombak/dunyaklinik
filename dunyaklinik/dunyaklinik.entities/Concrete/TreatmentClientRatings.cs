using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class TreatmentClientRatings : IEntity
    {
        [Key]
        public int id { get; set; }
        public int treatment_id { get; set; }
        public string explanation { get; set; }
        public int rate { get; set; }
        public int service_user_id { get; set; }
        public bool is_deleted { get; set; }
        public DateTime? created_time { get; set; }
        public DateTime? updated_time { get; set; }
        public int client_user_id { get; set; }
    }
}
