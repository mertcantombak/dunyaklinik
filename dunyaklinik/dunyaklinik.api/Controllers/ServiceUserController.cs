using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;
using dunyaklinik.entities.Concrete.MyObjects;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUserController : ControllerBase
    {
        private readonly DunyaKlinikContext _context;
        private IServiceUserService _service;
        public ServiceUserController(IServiceUserService service, DunyaKlinikContext context)
        {
            _service = service;
            _context = context;
        }

        [HttpGet]
        [Route("GetServiceUsers")]
        public List<ServiceUser> GetServiceUsers()
        {
            var serviceUsers = _service.GetList();
            return serviceUsers;
        }

        [HttpGet]
        [Route("GetServiceUsersById")]
        public ServiceUser GetServiceUsersById(int UserId)
        {
            var serviceUser = _context.ServiceUsers
                .Include(q => q.User)
                .FirstOrDefault(q => q.UserId == UserId);
            return serviceUser;
        }
        [HttpGet]
        [Route("GetServiceUsersByProfessionId")]
        public List<MyServiceUser> GetServiceUsersByProfessionId(int ProfessionId)
        {
            List<MyServiceUser> myServiceUsers = new List<MyServiceUser>();
            var serviceUser = _context.ServiceUsers
                .Include(q => q.User)
                .Include(q => q.Title)
                .Include(q => q.Profession)
                .Where(q => q.ProfessionId == ProfessionId)
                .ToList();
            if (serviceUser.Any())
            {
                foreach (var su in serviceUser)
                {
                    MyServiceUser sUser = new MyServiceUser();
                    sUser.Id = su.Id;
                    sUser.UserId= su.UserId;
                    sUser.Firstname = su.User.Firstname;
                    sUser.Lastname= su.User.Lastname;
                    sUser.Gender = su.User.Gender;
                    sUser.Phone= su.User.Phone;
                    sUser.PhoneCode= su.User.PhoneCode;
                    sUser.MailAddress= su.User.MailAddress;
                    sUser.ProfessionId = su.ProfessionId;
                    sUser.ProfessionName = su.Profession.ProfessionName;
                    sUser.ProfessionDescription = su.Profession.Description;
                    sUser.TitleId= su.TitleId;
                    sUser.TitleName = su.Title.TitleName;
                    sUser.BranchId= su.BranchId;
                    sUser.ProfileImagePath= su.ProfileImagePath;
                    sUser.Description = su.Description;
                    myServiceUsers.Add(sUser);
                }
            }
            return myServiceUsers;
        }
    }
}
