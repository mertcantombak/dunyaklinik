using Microsoft.AspNetCore.Mvc;
using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using dunyaklinik.entities.Concrete.MyObjects;

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
        public MyTreatment GetTreatmentsByUserId(int UserId)
        {
            MyTreatment myTreatment = new MyTreatment();
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
                .OrderByDescending(q => q.StartTime)
                .FirstOrDefault(q => q.UserId == UserId && !q.IsDeleted && !q.IsFinished);
            if (treatment != null)
            {
                myTreatment.Id = treatment.Id;
                myTreatment.ServiceUserId = treatment.ServiceUserId;
                myTreatment.UserId = treatment.UserId;
                myTreatment.TreatmentTypeId = treatment.TreatmentTypeId;
                myTreatment.Firstname = treatment.User.Firstname;
                myTreatment.Lastname = treatment.User.Lastname;
                myTreatment.StartTime = treatment.StartTime;
                myTreatment.EndTime = treatment.EndTime;
                myTreatment.Explanation= treatment.Explanation;
                myTreatment.IsDeleted= treatment.IsDeleted;
                myTreatment.IsFinished= treatment.IsFinished;
                myTreatment.IsTransferred= treatment.IsTransferred;
                myTreatment.ServiceUserFirstname = treatment.ServiceUser.User.Firstname;
                myTreatment.ServiceUserLastname = treatment.ServiceUser.User.Lastname;
                myTreatment.TreaatmentTypeName = treatment.TreatmentType.Name;
                myTreatment.ProfessionName = treatment.ServiceUser.Profession.ProfessionName;
                myTreatment.TitleName = treatment.ServiceUser.Title.TitleName;
            }
            return myTreatment;
        }
    }
}
