using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;
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
        [Route("GetAppointmentsByUserId")]
        public Appointment GetAppointmentsByUserId(int UserId)
        {
            var appointment = _context.Appointments
                .Include(q => q.User)
                .Include(q => q.ServiceUser.User)
                .Include(q => q.ServiceUser.Title)
                .Include(q => q.ServiceUser.Profession)
                .FirstOrDefault(q => q.UserId == UserId);

            return appointment;
        }
    }
}
