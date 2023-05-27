using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("GetUsers")]
        public List<User> GetUsers()
        {
            var users = _userService.GetList();

            return users;
        }
        [HttpPost]
        [Route("AddUserPost")]
        public void AddUserPost()
        {
            User user = new User(); 
            user.BirthDate = DateTime.Now;
            user.UpdatedTime = DateTime.Now;
            user.MailAddress = "savcicagri7@gmail.com";
            user.Phone = "5301666822";
            user.PhoneCode = "+90";
            user.Gender = "male";
            user.Firstname = "Batı";
            user.Lastname = "Savcı";
            user.IsMailVerified = true;
            user.IsActive= true;
            user.IsPhoneVerified= true;
            user.CreatedTime = DateTime.Now;
            user.IdentityCardNo = "12345678912";
            user.UserType = 1;
            user.Password = "1";
            user.Nationality = "Turkish";
            _userService.Add(user);
        }
    }
}
