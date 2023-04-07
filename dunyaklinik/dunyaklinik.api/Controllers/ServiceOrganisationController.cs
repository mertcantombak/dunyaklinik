using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceOrganisationController
    {
        private IServiceOrganisationService _service;
        public ServiceOrganisationController(IServiceOrganisationService service)
        {
            _service = service;
        }
        [HttpGet]
        [Route("GetServiceOrganisations")]
        public List<ServiceOrganisation> GetOrganisation()
        {
            var serviceOrganisations = _service.GetList();
            return serviceOrganisations;
        }
    }
}
