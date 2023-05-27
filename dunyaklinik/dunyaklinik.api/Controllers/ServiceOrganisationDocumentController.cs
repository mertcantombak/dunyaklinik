using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceOrganisationDocumentController : ControllerBase
    {
        private IServiceOrganisationDocumentService _service;
        public ServiceOrganisationDocumentController(IServiceOrganisationDocumentService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceOrganisationDocuments")]
        public List<ServiceOrganisationDocument> GetServiceOrganisationDocuments()
        {
            var serviceOrganisationDocuments = _service.GetList();
            return serviceOrganisationDocuments;
        }
    }
}
