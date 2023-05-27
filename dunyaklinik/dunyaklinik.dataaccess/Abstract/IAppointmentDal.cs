using dunyaklinik.core.DataAccess;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.dataaccess.Abstract
{
    public interface IAppointmentDal : IEntityRepository<Appointment>
    {
    }
}
