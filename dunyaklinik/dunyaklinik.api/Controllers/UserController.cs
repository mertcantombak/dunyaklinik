using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
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
        private readonly DunyaKlinikContext _context;

        public UserController(IUserService userService, DunyaKlinikContext context)
        {
            _userService = userService;
            _context = context;
        }
        [HttpGet]
        [Route("GetUsers")]
        public List<User> GetUsers()
        {
            var users = _userService.GetList();

            return users;
        }
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
                var firstname = HttpContext.Request.Query["firstname"];
                var lastname = HttpContext.Request.Query["lastname"];
                var identity_card_no = HttpContext.Request.Query["identity_card_no"];
                var password = HttpContext.Request.Query["password"];
                var phone = HttpContext.Request.Query["phone"];
                var phone_code = HttpContext.Request.Query["phone_code"];
                var gender = HttpContext.Request.Query["gender"];
                var mail_address = HttpContext.Request.Query["mail_address"];
                var birth_date = HttpContext.Request.Query["birth_date"];

                DateTime birthDate = Convert.ToDateTime(birth_date);
                
                var user = new User
                {
                    Firstname = firstname,
                    Lastname = lastname,
                    MailAddress = mail_address,
                    Phone = phone,
                    PhoneCode = phone_code,
                    BirthDate = birthDate.Date,
                    Gender = gender,
                    IsActive = true,
                    IsMailVerified = true,
                    IsPhoneVerified = true,
                    CreatedTime = DateTime.Now,
                    IdentityCardNo = identity_card_no,
                    Password = password,
                    UserType = 1,
                    Nationality = "Turkish",
                };
                var haveUser = _context.Users.Any(q => q.IdentityCardNo== user.IdentityCardNo || q.Phone == user.Phone || q.MailAddress == user.MailAddress);
                if (!haveUser)
                {
                    _userService.Add(user);
                    result.id = 1;
                    result.message = "Kayıt Başarılı";
                }
                else {
                    result.id = -1;
                    result.message = "İlgili bilgelere sahip hesap mevcut. Lütfen bilgilerinizi kontrol edin.";
                }
                
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
