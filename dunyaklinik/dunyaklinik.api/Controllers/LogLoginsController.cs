using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogLoginsController : ControllerBase
    {
        private ILogLoginsService _service;

        public LogLoginsController(ILogLoginsService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetLogLogins")]
        public List<LogLogins> GetLogLogins()
        {
            var logLogins = _service.GetList();

            return logLogins;
        }
    }
}
