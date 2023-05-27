using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogLoginController : ControllerBase
    {
        private ILogLoginService _service;

        public LogLoginController(ILogLoginService service)
        {
            _service = service;
        }

        [HttpGet]
        [Route("GetLogLogins")]
        public List<LogLogin> GetLogLogins()
        {
            var logLogins = _service.GetList();

            return logLogins;
        }
    }
}
