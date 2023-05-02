using dunyaklinik.business.Abstract;
using dunyaklinik.entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dunyaklinik.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private IUsersService _userService;

        public UsersController(IUsersService userService)
        {
            _userService = userService;
        }
        [HttpGet]
        [Route("GetUsers")]
        public List<Users> GetUsers()
        {
            var users = _userService.GetList();

            return users;
        }
        [HttpPost]
        [Route("AddUserPost")]
        public Result AddUserPost()
        {
            Result result = new Result();
            try
            {
                var user_id = HttpContext.Request.Query["user_id"];
                var firstname = HttpContext.Request.Query["firstname"];
                var lastname = HttpContext.Request.Query["lastname"];
                var identity_card_no = HttpContext.Request.Query["identity_card_no"];
                var password = HttpContext.Request.Query["password"];
                var phone = HttpContext.Request.Query["phone"];
                var phone_code = HttpContext.Request.Query["phone_code"];
                var gender = HttpContext.Request.Query["gender"];
                var mail_address = HttpContext.Request.Query["mail_address"];
                var birth_date = HttpContext.Request.Query["birth_date"];

                int userId = Convert.ToInt32(user_id);

                Users user = new Users
                {
                    firstname = firstname,
                    lastname = lastname,
                    mail_address = mail_address,
                    phone = phone,
                    phone_code = phone_code,
                    gender = gender,
                    is_active = false,
                    is_mail_verified = false,
                    is_phone_verified = false,
                    created_time = DateTime.Now,
                    identity_card_no = identity_card_no,
                    password = password,
                    user_type = 1,
                    nationality = "Turkish",
                };
                var image = HttpContext.Request.Form.Files.Count > 0 ?
                                                HttpContext.Request.Form.Files[0] : null;
                _userService.Add(user);
            }
            catch (Exception ex)
            {
                result.id = -1;
                result.message = "Bir Hata Oluştu!";
                throw;
            }
            //Users user = new Users(); 
            //user.birth_date = DateTime.Now;
            //user.updated_time = DateTime.Now;
            //user.mail_address = "savcicagri7@gmail.com";
            //user.phone = "5301666822";
            //user.phone_code = "+90";
            //user.gender = "male";
            //user.firstname = "Batı";
            //user.lastname = "Savcı";
            //user.is_mail_verified = true;
            //user.is_active= true;
            //user.is_phone_verified= true;
            //user.created_time = DateTime.Now;
            //user.identity_card_no = "12345678912";
            //user.user_type = 1;
            //user.password = "1";
            //user.nationality = "Turkish";
            return result;
        }
    }
}
