using dunyaklinik.core.Entities;
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
    public class nesne : IEntity
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public bool active { get; set; }
    }
}
