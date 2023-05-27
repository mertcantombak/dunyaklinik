using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;
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
    }
}
