using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;
using dunyaklinik.entities.Concrete.MyObjects;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
        
        #region Get-Methods
        [HttpGet]
        [Route("GetUserAppointments")]
        public List<MyAppointment> GetUserAppointments(int UserId, bool? isActive, bool? isDeleted, bool? isConfirmed)
        {
            var myAppointments = new List<MyAppointment>();
            var appointments = _context.Appointments
                .Include(q => q.User)
                .Include(q => q.ServiceUser.User)
                .Include(q => q.ServiceUser.Title)
                .Include(q => q.ServiceUser.Profession)
                .Where(q => q.UserId == UserId && q.IsActive == isActive && q.IsDeleted == isDeleted && q.IsConfirmed == isConfirmed)
                .OrderByDescending(q => q.AppointmentTime)
                .ToList();
            if (appointments.Any())
            {
                foreach (var appointment in appointments)
                {
                    MyAppointment myAppointment = new MyAppointment();
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
                    myAppointment.ProfessionDescription = appointment.ServiceUser.Profession.Description;
                    myAppointment.TitleName = appointment.ServiceUser.Title.TitleName;
                    myAppointments.Add(myAppointment);
                }
            }
            return myAppointments;
        }

        [HttpGet]
        [Route("GetAppointmentByUserId")]
        public MyAppointment GetAppointmentByUserId(int UserId)
        {
            MyAppointment myAppointment = new MyAppointment();
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
                myAppointment.ProfessionDescription = appointment.ServiceUser.Profession.Description;
                myAppointment.TitleName = appointment.ServiceUser.Title.TitleName;
            }
            return myAppointment;
        }
        #endregion

        #region Post-Methods
        [HttpPost]
        [Route("AddAppointmentByClient")]
        public async Task<Result> AddAppointmentByClientAsync()
        {
            Result result = new Result();
            try
            {
                using StreamReader reader = new StreamReader(HttpContext.Request.Body);
                string requestBody = await reader.ReadToEndAsync();
                var appointmentBody = JsonConvert.DeserializeObject<Appointment>(requestBody);
                var appointment = new Appointment
                {
                    ServiceUserId = appointmentBody.ServiceUserId,
                    UserId = appointmentBody.UserId,
                    AppointmentTime = appointmentBody.AppointmentTime,
                    CreatedTime = DateTime.Now,
                    IsActive = true,
                    IsDeleted = false,
                    IsConfirmed = false
                };
                _service.Add(appointment);
                result.id = 1;
                result.message = "Randevu kaydı başarılı.";
            }
            catch (Exception ex)
            {
                result.id = -1;
                result.message = "Bir Hata Oluştu!";
                throw;
            }
            return result;
        }

        [HttpPost]
        [Route("DeleteAppointmentById")]
        public async Task<Result> DeleteAppointmentById()
        {
            Result result = new Result();
            try
            {
                using StreamReader reader = new StreamReader(HttpContext.Request.Body);
                string requestBody = await reader.ReadToEndAsync();
                var appointmentBody = JsonConvert.DeserializeObject<Appointment>(requestBody);
                var appointment = _service.Get(q => q.Id == appointmentBody.Id);
                if(appointment != null)
                {
                    appointment.UpdatedTime = DateTime.Now;
                    appointment.IsActive = false;
                    appointment.IsDeleted = true;
                    _service.Update(appointment);
                    result.id = 1;
                    result.message = "Randevu başarıyla pasife alındı.";
                }
                else
                {
                    result.id = -1;
                    result.message = "Böyle bir randevu bulunamadi.";
                }
                
            }
            catch (Exception ex)
            {
                result.id = -1;
                result.message = "Bir Hata Oluştu!";
                throw;
            }
            return result;
        }
        #endregion
    }
}
