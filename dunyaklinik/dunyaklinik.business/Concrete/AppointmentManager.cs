using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class AppointmentManager : IAppointmentService
    {
        private IAppointmentDal _appointmentDal;
        public AppointmentManager(IAppointmentDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public void Add(Appointment appointment)
        {
            _appointmentDal.Add(appointment);
        }

        public void Delete(Appointment appointment)
        {
            _appointmentDal.Delete(appointment);
        }

        public Appointment Get(Expression<Func<Appointment, bool>> filter = null)
        {
            return _appointmentDal.Get(filter);
        }

        public List<Appointment> GetList(Expression<Func<Appointment, bool>> filter = null)
        {
            return _appointmentDal.GetList(filter);
        }

        public void Update(Appointment appointment)
        {
            _appointmentDal.Update(appointment);
        }
    }
}
