﻿using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class Appointment : IEntity
    {
        public int Id { get; set; }

        public int ServiceUserId { get; set; }

        public int UserId { get; set; }

        public DateTime AppointmentTime { get; set; }

        public DateTime CreatedTime { get; set; }

        public DateTime? UpdatedTime { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsConfirmed { get; set; }

        public virtual User User { get; set; } = null!;

        public virtual ServiceUser ServiceUser { get; set; } = null!;
    }
}
