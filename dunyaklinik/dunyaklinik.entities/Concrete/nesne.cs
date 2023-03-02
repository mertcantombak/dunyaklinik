using dunyaklinik.core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.entities.Concrete
{
    public class nesne : IEntity
    {
        public int id { get; set; }
        public string ad { get; set; }
    }
}
