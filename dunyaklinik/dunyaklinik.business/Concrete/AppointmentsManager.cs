using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Abstract;
using dunyaklinik.entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dunyaklinik.business.Concrete
{
    public class AppointmentsManager : IAppointmentsService
    {
        private IAppointmentsDal _appointmentDal;
        public AppointmentsManager(IAppointmentsDal appointmentDal)
        {
            _appointmentDal = appointmentDal;
        }

        public void Add(Appointments appointment)
        {
            _appointmentDal.Add(appointment);
        }

        public void Delete(Appointments appointment)
        {
            _appointmentDal.Delete(appointment);
        }

        public List<Appointments> GetList()
        {
            return _appointmentDal.GetList();
        }

        public void Update(Appointments appointment)
        {
            _appointmentDal.Update(appointment);
        }
    }
}
