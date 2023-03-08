using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
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
        public List<nesne> GetNesnes()
        {
            var nesnes = _nesneService.GetList();

            return nesnes;
        }

        [HttpPost]
        public void AddNesnePost()
        {
            nesne n = new nesne();
            n.ad = "BaMe";
            n.active = true;
            _nesneService.Add(n);
        }
    }
}
