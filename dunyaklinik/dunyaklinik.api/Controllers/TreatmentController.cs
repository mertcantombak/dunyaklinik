using Microsoft.AspNetCore.Mvc;
using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TreatmentController : ControllerBase
    {
        private readonly DunyaKlinikContext _context;
        private ITreatmentService _service;
        public TreatmentController(ITreatmentService service, DunyaKlinikContext context) 
        {
            _context = context;
            _service = service;
        }
        [HttpGet]
        [Route("GetTreatments")]
        public List<Treatment> GetTreatments()
        {
            var treatments = _service.GetList();

            return treatments;
        }

        [HttpGet]
        [Route("GetTreatmentsByUserId")]
        public Treatment GetTreatmentsByUserId(int UserId)
        {
            var treatment = _context.Treatments
                .Include(q => q.User)
                .Include(q => q.ServiceUser.User)
                .Include(q => q.ServiceUser.Title)
                .Include(q => q.ServiceUser.Profession)
                .Include(q => q.TreatmentClientRatings)
                .Include(q => q.TreatmentDocuments)
                .Include(q => q.TreatmentExercises)
                .Include(q => q.TreatmentServiceRatings)
                .Include(q => q.TreatmentType)
                .FirstOrDefault(q => q.UserId == UserId);

            return treatment;
        }
    }
}
