using dunyaklinik.business.Abstract;
using dunyaklinik.dataaccess.Concrete.EntityFramework;
using dunyaklinik.entities.Concrete;
using dunyaklinik.entities.Concrete.MyObjects;
using MernisService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
        #region Get-Methods
        [HttpGet]
        [Route("GetUserByUserId")]
        public MyUser GetUserByUserId(int userId)
        {
            MyUser user = new MyUser();
            var u = _userService.Get(q => q.UserId == userId);
            user.Firstname = u.Firstname;
            user.Lastname = u.Lastname;
            user.PhoneCode = u.PhoneCode;
            user.Phone = u.Phone;
            user.MailAddress = u.MailAddress;
            user.IdentityCardNo = u.IdentityCardNo;
            user.Gender = u.Gender;
            user.BirthDateStr = u.BirthDate.Value.ToShortDateString();
            return user;
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
        #endregion
        #region Post-Methods
        [HttpPost]
        [Route("AddUserPost")]
        public async Task<Result> AddUserPostAsync()
        {
            Result result = new Result();
            bool kimlikDurum = false;
            try
            {
                using StreamReader reader = new StreamReader(HttpContext.Request.Body);
                string requestBody = await reader.ReadToEndAsync();
                var userBody = JsonConvert.DeserializeObject<User>(requestBody);
                var user = new User
                {
                    Password = userBody.Password,
                    MailAddress = userBody.MailAddress,
                    UserType = userBody.UserType,
                    Firstname = userBody.Firstname,
                    Lastname = userBody.Lastname,
                    Nationality = userBody.Nationality,
                    IdentityCardNo = userBody.IdentityCardNo,
                    Gender = userBody.Gender,
                    BirthDate = userBody.BirthDate,
                    Phone = userBody.Phone,
                    PhoneCode = userBody.PhoneCode,
                    IsPhoneVerified = true,
                    IsMailVerified = true,
                    CreatedTime = DateTime.Now,
                };
                var haveUser = _context.Users.Any(q => q.IdentityCardNo == user.IdentityCardNo || q.Phone == user.Phone || q.MailAddress == user.MailAddress);
                int dogumYil = user.BirthDate.Value.Year;
                long tc = long.Parse(user.IdentityCardNo);
                var client = new MernisService.KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
                var response = await client.TCKimlikNoDogrulaAsync(tc, user.Firstname.Trim(), user.Lastname.Trim(), dogumYil);
                kimlikDurum = response.Body.TCKimlikNoDogrulaResult;
                if (kimlikDurum)
                {
                    if (!haveUser)
                    {
                        _userService.Add(user);
                        result.id = 1;
                        result.message = "Kayıt Başarılı";
                    }
                    else
                    {
                        result.id = -1;
                        result.message = "İlgili bilgelere sahip hesap mevcut. Lütfen bilgilerinizi kontrol edin.";
                    }
                }
                else
                {
                    result.id = -1;
                    result.message = "Girilen kimlik bilgileri kontrol edilmeli. Kayıt yapılamadı.";
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
        #endregion

    }
}
