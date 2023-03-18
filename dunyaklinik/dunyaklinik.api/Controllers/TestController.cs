using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private INesneService _nesneService;

        public TestController(INesneService nesneService)
        {
            _nesneService = nesneService;
        }

        [HttpGet]
        [Route("GetNesnes")]
        public List<nesne> GetNesnes()
        {
            var nesnes = _nesneService.GetList().Where(s => s.active).ToList();

            return nesnes;
        }

        [HttpPost]
        [Route("AddNesnePost")]
        public void AddNesnePost()
        {
            nesne n = new nesne();
            n.ad = "test route 1603";
            n.active = false;
            _nesneService.Add(n);
        }
    }
}
