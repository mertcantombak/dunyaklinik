﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class Service_User_Professions
    {
        [Key]
        public int id { get; set; }
        public string profession_name { get; set; }
        public string description { get; set; }
        public DateTime created_time { get; set; }
        public DateTime updated_time { get; set; }
        public bool is_active { get; set; }
    }
}
