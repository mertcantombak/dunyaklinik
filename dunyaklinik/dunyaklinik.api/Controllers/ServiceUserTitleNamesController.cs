using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUserTitleNamesController : ControllerBase
    {
        private IServiceUserTitleNamesService _service;
        public ServiceUserTitleNamesController(IServiceUserTitleNamesService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceUserTitleNames")]
        public List<ServiceUserTitleNames> GetServiceUserTitleNames()
        {
            var serviceUserTitleNames = _service.GetList();
            return serviceUserTitleNames;
        }
    }
}
