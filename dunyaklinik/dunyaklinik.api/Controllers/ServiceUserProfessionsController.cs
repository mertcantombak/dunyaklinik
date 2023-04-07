using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUserProfessionsController
    {
        private IServiceUserProfessionsService _service;
        public ServiceUserProfessionsController(IServiceUserProfessionsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceUserProfessions")]
        public List<ServiceUserProfessions> GetServiceUserProfessions()
        {
            var serviceUserProfessions = _service.GetList();
            return serviceUserProfessions;
        }
    }
}
