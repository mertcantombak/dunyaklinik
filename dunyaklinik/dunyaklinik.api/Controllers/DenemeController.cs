using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DenemeController : ControllerBase
    {
        private IDenemeService _nesneService;

        public DenemeController(IDenemeService nesneService)
        {
            _nesneService = nesneService;
        }

        [HttpGet]
        [Route("GetNesnes")]
        public List<Deneme> GetNesnes()
        {
            var nesnes = _nesneService.GetList().Where(s => (bool)s.Active).ToList();

            return nesnes;
        }

        [HttpPost]
        [Route("AddNesnePost")]
        public void AddNesnePost()
        {
            Deneme n = new Deneme();
            n.Ad = "test route 1603";
            n.Active = false;
            _nesneService.Add(n);
        }
    }
}
