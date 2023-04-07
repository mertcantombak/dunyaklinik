using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceBranchGeneralController
    {
        private IServiceBranchGeneralService _service;
        public ServiceBranchGeneralController(IServiceBranchGeneralService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetServiceBranchGenerals")]
        public List<ServiceBranchGeneral> GetServiceBranchGenerals()
        {
            var serviceBranchGenerals = _service.GetList();
            return serviceBranchGenerals;
        }

    }
}
