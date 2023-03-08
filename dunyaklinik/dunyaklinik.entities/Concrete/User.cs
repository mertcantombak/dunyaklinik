using dunyaklinik.core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class User : IEntity
    {
        [Key]
        public int user_id { get; set; }
        public string password { get; set; }        
        public string mail_address { get; set; }
        public int user_type { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nationality { get; set; }
        public string identity_card_no { get; set; }
        public string gender { get; set; }
        public DateTime birth_date { get; set; }
        public string phone_code { get; set; }
        public string phone { get; set; }
        public bool is_active { get; set; }
        public bool is_phone_verified { get; set; }
        public bool is_mail_verified { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
    }
}
