using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUserTitleNameController : ControllerBase
    {
        private IServiceUserTitleNameService _service;
        public ServiceUserTitleNameController(IServiceUserTitleNameService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceUserTitleNames")]
        public List<ServiceUserTitleName> GetServiceUserTitleNames()
        {
            var serviceUserTitleNames = _service.GetList();
            return serviceUserTitleNames;
        }
    }
}
