﻿using dunyaklinik.core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class Deneme : IEntity
    {
        public int Id { get; set; }

        public string? Ad { get; set; }

        public bool? Active { get; set; }
    }
}
