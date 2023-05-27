using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceBranchDocumentController : ControllerBase
    {
        private IServiceBranchDocumentService _service;
        public ServiceBranchDocumentController(IServiceBranchDocumentService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceBranchDocuments")]
        public List<ServiceBranchDocument> GetServiceBranchDocuments()
        {
            var serviceBranchDocuments = _service.GetList();
            return serviceBranchDocuments;
        }
    }
}
