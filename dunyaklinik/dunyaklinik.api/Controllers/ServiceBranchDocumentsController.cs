using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceBranchDocumentsController : ControllerBase
    {
        private IServiceBranchDocumentsService _service;
        public ServiceBranchDocumentsController(IServiceBranchDocumentsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceBranchDocuments")]
        public List<ServiceBranchDocuments> GetServiceBranchDocuments()
        {
            var serviceBranchDocuments = _service.GetList();
            return serviceBranchDocuments;
        }
    }
}
