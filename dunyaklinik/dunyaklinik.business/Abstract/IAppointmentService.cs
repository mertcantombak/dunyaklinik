using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Abstract
{
    public interface IAppointmentService
    {
        List<Appointment> GetList(Expression<Func<Appointment, bool>> filter = null);

        Appointment Get(Expression<Func<Appointment, bool>> filter = null);

        void Add(Appointment appointment);
        void Update(Appointment appointment);
        void Delete(Appointment appointment);
    }
}
