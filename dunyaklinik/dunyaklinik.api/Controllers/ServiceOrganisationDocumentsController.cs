using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceOrganisationDocumentsController : ControllerBase
    {
        private IServiceOrganisationDocumentsService _service;
        public ServiceOrganisationDocumentsController(IServiceOrganisationDocumentsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceOrganisationDocuments")]
        public List<ServiceOrganisationDocuments> GetServiceOrganisationDocuments()
        {
            var serviceOrganisationDocuments = _service.GetList();
            return serviceOrganisationDocuments;
        }
    }
}
