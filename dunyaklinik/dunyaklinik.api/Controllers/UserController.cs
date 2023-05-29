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
        //[HttpPost]
        //[Route("AddUserPost")]
        //public void AddUserPost()
        //{
        //    User user = new User(); 
        //    user.BirthDate = DateTime.Now;
        //    user.UpdatedTime = DateTime.Now;
        //    user.MailAddress = "savcicagri7@gmail.com";
        //    user.Phone = "5301666822";
        //    user.PhoneCode = "+90";
        //    user.Gender = "male";
        //    user.Firstname = "Batı";
        //    user.Lastname = "Savcı";
        //    user.IsMailVerified = true;
        //    user.IsActive= true;
        //    user.IsPhoneVerified= true;
        //    user.CreatedTime = DateTime.Now;
        //    user.IdentityCardNo = "12345678912";
        //    user.UserType = 1;
        //    user.Password = "1";
        //    user.Nationality = "Turkish";
        //    _userService.Add(user);
        //}
        [HttpPost]
        [Route("UserLogin")]
        public Result UserLogin()
        {
            Result result = new Result();
            User user = new User();
            try
            {
                var MailAddress = HttpContext.Request.Query["mail_address"];
                var Password = HttpContext.Request.Query["password"];
                user = _userService.GetUser(MailAddress, Password);
                if (user != null)
                {
                    result.id = user.UserId;
                    result.message = "Giriş İşlemi Başarılı";
                }
                else
                {
                    result.id = -1;
                    result.message = "Giriş Yapılamadı. Bilgilerinizi Kontrol Edin!";
                }
            }
            catch (Exception ex)
            {
                result.id = -1;
                result.message = "Giriş Yapılamadı. Bir Hata Oluştu!";
                throw;
            }
            return result;
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

                //int userId = Convert.ToInt32(user_id);
                DateTime birthDate = Convert.ToDateTime(birth_date);
                var user = new User
                {
                    Firstname = firstname,
                    Lastname = lastname,
                    MailAddress = mail_address,
                    Phone = phone,
                    PhoneCode = phone_code,
                    //birth_date= user.birthDate,
                    BirthDate = DateTime.Now,
                    Gender = gender,
                    IsActive = false,
                    IsMailVerified = false,
                    IsPhoneVerified = false,
                    CreatedTime = DateTime.Now,
                    //updated_time= DateTime.Now,
                    IdentityCardNo = identity_card_no,
                    Password = password,
                    UserType = 1,
                    Nationality = "Turkish",
                };
                _userService.Add(user);
                result.id = 1;
                result.message = "Kayıt Başarılı";
            }
            catch (Exception ex)
            {
                result.id = -1;
                result.message = "Bir Hata Oluştu!";
                throw;
            }
            return result;
        }
    }
}
