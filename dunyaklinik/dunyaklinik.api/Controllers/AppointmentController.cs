using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;
using dunyaklinik.entities.Concrete.MyObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : ControllerBase
    {
        private readonly DunyaKlinikContext _context;
        private IAppointmentService _service;

        public AppointmentController(IAppointmentService service, DunyaKlinikContext context)
        {
            _context = context;
            _service = service;
        }

        [HttpGet]
        [Route("GetAppointments")]
        public List<Appointment> GetAppointments()
        {
            var appointments = _service.GetList();

            return appointments;
        }

        [HttpGet]
        [Route("GetAppointmentByUserId")]
        public MyAppointment GetAppointmentByUserId(int UserId)
        {
            MyAppointment myAppointment= new MyAppointment();
            var appointment = _context.Appointments
                .Include(q => q.User)
                .Include(q => q.ServiceUser.User)
                .Include(q => q.ServiceUser.Title)
                .Include(q => q.ServiceUser.Profession)
                .OrderByDescending(q => q.AppointmentTime)
                .FirstOrDefault(q => q.UserId == UserId && q.IsActive && !q.IsDeleted);
            if (appointment != null)
            {
                myAppointment.Id = appointment.Id;
                myAppointment.UserId = appointment.UserId;
                myAppointment.Firstname = appointment.User.Firstname;
                myAppointment.Lastname = appointment.User.Lastname;
                myAppointment.AppointmentTime = appointment.AppointmentTime;
                myAppointment.Firstname = appointment.User.Firstname;
                myAppointment.IsActive = appointment.IsActive;
                myAppointment.IsConfirmed = appointment.IsConfirmed;
                myAppointment.IsDeleted = appointment.IsDeleted;
                myAppointment.ServiceUserId = appointment.ServiceUserId;
                myAppointment.ServiceUserFirstname = appointment.ServiceUser.User.Firstname;
                myAppointment.ServiceUserLastname = appointment.ServiceUser.User.Lastname;
                myAppointment.ProfessionName = appointment.ServiceUser.Profession.ProfessionName;
                myAppointment.TitleName = appointment.ServiceUser.Title.TitleName;
            }
            return myAppointment;
        }
    }
}
