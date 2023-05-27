using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUserProfessionController
    {
        private IServiceUserProfessionService _service;
        public ServiceUserProfessionController(IServiceUserProfessionService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceUserProfessions")]
        public List<ServiceUserProfession> GetServiceUserProfessions()
        {
            var serviceUserProfessions = _service.GetList();
            return serviceUserProfessions;
        }
    }
}
