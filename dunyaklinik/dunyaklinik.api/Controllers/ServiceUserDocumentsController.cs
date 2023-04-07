using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceUserDocumentsController : ControllerBase
    {
        private IServiceUserDocumentsService _service;
        public ServiceUserDocumentsController(IServiceUserDocumentsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceUserDocuments")]
        public List<ServiceUserDocuments> GetServiceUserDocuments()
        {
            var serviceUserDocuments = _service.GetList();
            return serviceUserDocuments;
        }
    }
}
