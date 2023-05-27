using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUserDocumentController : ControllerBase
    {
        private IServiceUserDocumentService _service;
        public ServiceUserDocumentController(IServiceUserDocumentService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceUserDocuments")]
        public List<ServiceUserDocument> GetServiceUserDocuments()
        {
            var serviceUserDocuments = _service.GetList();
            return serviceUserDocuments;
        }
    }
}
