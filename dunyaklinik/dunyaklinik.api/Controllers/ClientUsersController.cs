using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientUsersController : ControllerBase
    {
        private IClientUsersService _service;
        public ClientUsersController(IClientUsersService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetClientUsers")]
        public List<ClientUsers> GetClientUsers()
        {
            var clientUsers = _service.GetList();
            return clientUsers;
        }
    }
}
