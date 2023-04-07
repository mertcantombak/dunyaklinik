using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUsersController : ControllerBase
    {
        private IServiceUsersService _service;
        public ServiceUsersController(IServiceUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceUsers")]
        public List<ServiceUsers> GetServiceUsers()
        {
            var serviceUsers = _service.GetList();
            return serviceUsers;
        }
    }
}
